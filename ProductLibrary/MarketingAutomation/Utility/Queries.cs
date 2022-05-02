using BaseUtility.Utility;
using MarketingAutomation.Entity;
using System.Data.SqlClient;

namespace MarketingAutomation.Utility
{
    public class Queries : BaseUtility.Utility.Queries
    {

        public static void GetCards(Campaign data, int id)
        {
            //clear the old items from the list
            data.clientCards.Clear();
            query = "SELECT Type FROM CAM.CampaignType" +
                    " WHERE CampaignTypeGroupId = " + id + "";
            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.clientCards.Add(reader["Type"].ToString());
                        }
                    }
                }
                connection.Close();
            }
        }


        public static void GetCampaignIdByName(Campaign data, string cName)
        {
            
            query = "SELECT CampaignId FROM cam.campaignversion WHERE name = '"+cName+"'";
                
            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.CampaignId=reader["CampaignId"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }
        public static void GetAudienceIdNameDescriptionUsingCampainId(Campaign data, int campaignId)
        {

            query = "SELECT cv.CampaignId,av.Name,av.Description,av.AudienceId from cam.campaign c " +
                    " JOIN cam.campaignversion cv on c.campaignid = cv.campaignid " +
                    " JOIN aud.audience a on a.audienceid = cv.audienceid " +
                    " JOIN aud.audienceversion av on a.audienceid = av.audienceid " +
                    " WHERE c.campaignid = "+ campaignId + " ";
                
            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.AudienceName=reader["Name"].ToString();
                            data.AudienceDescription=reader["Description"].ToString();
                            data.AudienceId=reader["AudienceId"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void GetTagsUsingAudienceId(Campaign data, int audienceId)
        {
            //clear the old items from the list
            data.AudienceTagNames.Clear();
            query = "SELECT at.Name from aud.Audience a " +
                    " JOIN aud.audienceversion av on a.audienceversionid = av.audienceversionid " +
                    " JOIN aud.audienceversiontag avt on av.audienceversionid = avt.audienceversionid " +
                    " JOIN aud.audiencetag at on avt.audiencetagid = at.audiencetagid where a.AudienceId = "+ audienceId + "";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.AudienceTagNames.Add(reader["Name"].ToString());
                        }
                    }
                }
                connection.Close();
            }
        }
        public static void GetAudienceNameBasedOnAudienceCount(Campaign data, int audienceCount)
        {

            query = "select top 1 avfc.count as AudienceCount,av.name as AudienceName " +
                    " from aud.audienceversionforecastcount avfc join aud.audienceversionforecast avf " +
                    " on avfc.audienceversionforecastid = avf.audienceversionforecastid join aud.audienceversion av on " +
                    " avf.audienceversionid = av.audienceversionid where avfc.count = "+ audienceCount + "";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.AudienceName = reader["AudienceName"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }


        public static void GetCampaignsCountBasedOnAudienceAndForecastTypeId(Campaign data, string audienceName,int forecastTypeId)
        {
             query = "Select avfc.Count, "+
                    " (select count(*) from cam.CampaignVersion " +
                    " join cam.Campaign on campaign.CampaignVersionId = campaignversion.CampaignVersionId " +
                    " where AudienceId = av.audienceid and deleted = 0) as CampaignsCount, av.UpdateDate " +
                    " From aud.Audience a JOIN aud.AudienceVersion av ON a.AudienceId = av.AudienceId "+
                    " Left join aud.AudienceVersionForecast avf ON av.AudienceVersionId = avf.AudienceVersionId "+
                    " left join aud.AudienceVersionForecastCount avfc on avf.AudienceVersionForecastId = avfc.AudienceVersionForecastId "+
                    " where av.Name like '"+ audienceName + "' and avfc.ForecastTypeId = "+ forecastTypeId + " "+
                    " Order by a.AudienceId ASC";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.CampaignsCount = reader["CampaignsCount"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void DeleteCampaignOrGetItBackBasedOnId(int campaignId, int deleteFlag)
        {
            query = "Update cam.campaign Set deleted = "+ deleteFlag + " where campaignid = "+ campaignId + " ";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader()) { }
                }
                connection.Close();
            }
        }


        public static void GetCampaignsDetailsBasedOnAudienceAndForecastTypeId(Campaign data, string audienceName, int forecastTypeId)
        {
            query = "SELECT a.AudienceId, name, av.CriteriaCount, "+
                    " (SELECT tags = STUFF((SELECT ', ' + name FROM aud.AudienceTag at JOIN aud.audienceversiontag "+
                    " avt ON at.AudienceTagId = avt.AudienceTagId WHERE avt.AudienceVersionId = av.AudienceVersionId "+
                    " FOR XML PATH('')), 1, 1, '')) as Tags, "+
                    " avfc.Count, "+
	                " (select count(*) from cam.CampaignVersion "+
                    " join cam.Campaign on campaign.CampaignVersionId = campaignversion.CampaignVersionId "+
                    " where AudienceId = av.audienceid and deleted = 0) as Campaigns, av.UpdateDate "+
                    " FROM aud.Audience a JOIN aud.AudienceVersion av ON a.AudienceId = av.AudienceId "+
                    " LEFT JOIN aud.AudienceVersionForecast avf ON av.AudienceVersionId = avf.AudienceVersionId "+
                    " LEFT JOIN aud.AudienceVersionForecastCount avfc ON avf.AudienceVersionForecastId = avfc.AudienceVersionForecastId "+
                    " where av.Name like '"+ audienceName + "' "+
                    " and avfc.ForecastTypeId = "+ forecastTypeId + " "+
                    " ORDER BY a.AudienceId ASC";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.AudienceName = reader["name"].ToString();
                            data.CriteriaCount = reader["CriteriaCount"].ToString();
                            data.AudienceTags = reader["Tags"].ToString();
                            data.AudienceCount = reader["Count"].ToString();
                            data.CampaignsCount = reader["Campaigns"].ToString();
                            data.AudienceUpdateDate = reader["UpdateDate"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }


        public static void GetCampaignsCountForTheDesignUsingName(Campaign data, string designName)
        {
            query = " select t.name as TemplateName, count(cv.name) as CampaignCount from cam.campaign c " +
                    " inner join cam.campaignversion cv on c.campaignid = cv.campaignid and c.campaignversionId = cv.campaignversionId " +
                    " left outer join emt.template t on t.templateid = cv.templateid " +
                    " group by t.name having t.name = '" + designName + "'";

            data.TemplateName = designName;
            data.CampaignsCount = "0";
            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.TemplateName = reader["TemplateName"].ToString();
                            data.CampaignsCount = reader["CampaignCount"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }
        
        public static void GetTemplateNameBasedOnName(Campaign data, string templateName)
        {
            query = "Select TOP 1 Name as TemplateName from emt.Template where Name='"+ templateName + "'";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.TemplateName = reader["TemplateName"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void GetTemplateIDBasedOnName(Campaign data, string templateName)
        {
            query = "select TOP 1 TemplateId  from emt.Template where Name='" + templateName + "'";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.TemplateId = reader["TemplateId"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void GetTagsUsingDesignTemplateId(Campaign data, int templateId)
        {
            //clear the old items from the list
            data.DesignTagNames.Clear();
            query = " select templateid, name as TagName from emt.templatetemplatetag as ttt "+
                    " inner join emt.templatetag as tt on ttt.templatetagid = tt.templatetagid "+
                    " where templateid = "+ templateId + "";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.DesignTagNames.Add(reader["TagName"].ToString().Trim());
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void GetUpdateByIdBasedOngDesignTemplateName(Campaign data, string templateName)
        {
            
            query = "select TOP 1 TemplateId, Name, UpdateBy as UpdateById from emt.Template where Name='"+ templateName + "'";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.UpdateById= reader["UpdateById"].ToString().Trim();
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void GetUserFirstAndLastNameBasedOnId(Campaign data, int updateById)
        {

            query = "select TOP 1 UserId, FirstName as UserFirstName, LastName  as UserLastName from Users where UserId="+updateById+"";

            using (SqlConnection connection = DBHelper.SqlConn2())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.UserFirstName = reader["UserFirstName"].ToString().Trim();
                            data.UserLastName = reader["UserLastName"].ToString().Trim();
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void GetCreateUpdateDateBasedOngDesignTemplateName(Campaign data, string templateName)
        {

            query = "select TOP 1 Name,CreateDate,UpdateDate from [emt].[Template] where Name='"+ templateName + "'";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.CreateDate = reader["CreateDate"].ToString().Trim();
                            data.UpdateDate = reader["UpdateDate"].ToString().Trim();
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void GetCampaignFrequencyBasedOngNameAndId(Campaign data, string campaignName, int campaignId)
        {

            
            query = "select Frequency from[cam].[campaignversion] where Name = '"+ campaignName + "' and campaignId = "+ campaignId + "";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.CampaignFrequency = reader["Frequency"].ToString().Trim();
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void GetCampaignsIDBasedOnManageCampaignName(Campaign data, string cName)
         {
            query = "SELECT CampaignId FROM cam.campaignversion WHERE name = '" + cName + "'";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.CampaignId = reader["CampaignId"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void GetCampaignsNameandCompaireManageCampaignName(Campaign data, string cName)
        {
            query = "SELECT * FROM cam.campaignversion where name = '" + cName + "'";
            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.CampaignName = reader["Name"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void GetAudienceName(Campaign data, string cAUDIENCE)
        {
            query = "select * from [aud].[AudienceVersion] where Name = '" + cAUDIENCE + "'";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.AudienceName = reader["Name"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void GetStatusColumn(Campaign data, int cID)
        {
            query = "select Top 1 CampaignLog.CampaignId,CampaignStatus.CampaignStatusId,CampaignStatus.DisplayName" +
            " from[cam].[CampaignStatus]" +
            " LEFT JOIN[cam].[CampaignLog]" +
            " ON CampaignLog.CampaignStatusId=CampaignStatus.CampaignStatusId" +
            " where CampaignId = " + cID + "";



            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();



                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Status = reader["DisplayName"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void Audience_Card_View(Campaign data, string aName)
        {
            query = "select Top 1 AV.Name, AV.UpdateDate, AV.UpdateBy, AVT.AudienceVersionId, AVT.AudienceTagId, AT.Name AS Tag, AST.Name AS Status "+
                    " from[aud].[AudienceVersion] AS AV Inner JOIN[aud].[AudienceVersionTag]" +
                     " AS AVT" +
                     " ON AV.AudienceVersionId=AVT.AudienceVersionId Inner JOIN[aud].[AudienceTag] AS AT" +
                     " ON AT.AudienceTagId= AVT.AudienceTagId Inner JOIN [aud].[AudienceStatus] AS AST" +
                     " ON AV.AudienceStatusId= AST.AudienceStatusId where AV.Name = " + aName + "";



            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.AudienceName = reader["Name"].ToString();
                            data.AudienceStatus = reader["Status"].ToString();
                            data.AudienceUpdateDate = reader["UpdateDate"].ToString();
                            data.AudienceTags = reader["Tag"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void GetTemplateIdByName(Template data, string tName)
        {

            query = "SELECT TemplateId FROM [emt].[Template] WHERE name = '" + tName + "'";


            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.TemplateId = reader["TemplateId"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }

        public static void GetUnsubscribeAndBrowserLinkValueBasedOnTemplateId(Template data, string templateId)
        {

            query = "SELECT Unsubscribe, BrowserLink from [emt].[TemplateVersion] where TemplateId = '" + templateId + "'";

            using (SqlConnection connection = DBHelper.SqlConn())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandTimeout = 60;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Unsubscribe = reader["Unsubscribe"].ToString();
                            data.BrowserLink = reader["BrowserLink"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }
    }
}
