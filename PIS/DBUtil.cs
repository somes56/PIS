using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace PIS
{
    class DBUtil
    {
        public static string constring = ConfigurationManager.ConnectionStrings["PIS_DEFAULT"].ConnectionString;

        public  DBUtil()
        {


        }

        public static bool isExistinDB(string table, string column, string key)
        {
            bool flag = false;


            using (SqlConnection conn = new SqlConnection(constring))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT " +column+ " FROM " +table + " WHERE "+column+ "='" + key +"'", conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {

                                flag = true;
                            }
                            
                        }
                    }
                }


                catch (Exception ex)
                {
                    return false;

                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                }

                return flag;

            }
        }

        public static Tuple<float, float, float, float> GetTariff(int cargo_type, int days, float m3)
        {
            decimal handling = 0, faf = 0, storage = 0, removal = 0;
            int qday = 0, qm3 = 0;

            if (days > 3)
            {
                qday = 1;
            }

            if (m3 > 1)
            {
                qm3 = 1;

            }

            using (SqlConnection conn = new SqlConnection(constring))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT handling,faf,storage,removal FROM M_Tariff WHERE type=" + cargo_type + " AND days=" + qday + " AND m3=" + qm3, conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {

                                while (reader.Read())
                                {
                                    handling = reader.GetDecimal(reader.GetOrdinal("handling"));
                                    faf = reader.GetDecimal(reader.GetOrdinal("faf"));
                                    removal = reader.GetDecimal(reader.GetOrdinal("removal"));
                                    storage = reader.GetDecimal(reader.GetOrdinal("storage"));

                                }
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }

                }


                catch (Exception ex)
                {
                    return null;

                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                }


                return Tuple.Create((float)handling, (float)faf, (float)storage, (float)removal);

            }

        }


        public static string GetCompanyName(int id)
        {
            string name1 = "";


            using (SqlConnection conn = new SqlConnection(constring))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT name FROM M_CompanyInfo WHERE id=" + id, conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {

                                while (reader.Read())
                                {
                                    name1 = reader.GetString(reader.GetOrdinal("name"));

                                }
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }

                }


                catch (Exception ex)
                {
                    return null;

                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                }

                return name1.Trim();

            }
        }

        public static string GetVessel_Id(int id)
        {
            string name1 = "";


            using (SqlConnection conn = new SqlConnection(constring))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT name FROM M_Vessel WHERE id=" + id, conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {

                                while (reader.Read())
                                {
                                    name1 = reader.GetString(reader.GetOrdinal("name"));

                                }
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }

                }


                catch (Exception ex)
                {
                    return null;

                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                }

                return name1.Trim();

            }
        }

        public static string GetCountryName(int id)
        {
            string name1 = "";


            using (SqlConnection conn = new SqlConnection(constring))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT name FROM M_Country WHERE id=" + id , conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {

                                while (reader.Read())
                                {
                                    name1 = reader.GetString(reader.GetOrdinal("name"));

                                }
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }

                }


                catch (Exception ex)
                {
                    return null;

                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                }

                return name1.Trim();

            }
        }

        public static string GetStateName(int id)
        {
            string name1 = "";


            using (SqlConnection conn = new SqlConnection(constring))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT name FROM M_State WHERE id=" + id, conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {

                                while (reader.Read())
                                {
                                    name1 = reader.GetString(reader.GetOrdinal("name"));

                                }
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }

                }


                catch (Exception ex)
                {
                    return null;

                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                }

                return name1.Trim();

            }
        }

        public static string GetLocationName(int id)
        {
            string name1 = "";


            using (SqlConnection conn = new SqlConnection(constring))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT code FROM M_Location WHERE id=" + id, conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {

                                while (reader.Read())
                                {
                                    name1 = reader.GetString(reader.GetOrdinal("code"));

                                }
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }

                }


                catch (Exception ex)
                {
                    return null;

                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                }

                return name1.Trim();

            }
        }


        public static string GetTermName(int type)
        {
            string name1="";


            using (SqlConnection conn = new SqlConnection(constring))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT name FROM M_TERMS WHERE type=" + type.ToString(),conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {

                                while (reader.Read())
                                {
                                    name1 = reader.GetString(reader.GetOrdinal("name"));
                                    
                                }
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }

                }


                catch (Exception ex)
                {
                    return null;

                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                }

                return name1.Trim();

            }



        }

        public static string GetTermsName(int type)
        {
            SqlConnection _con = new SqlConnection(constring);
            string name1;

            SqlCommand command = new SqlCommand("GetTerm", _con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@type", SqlDbType.Int).Value = type;
            SqlParameter returnParameter = command.Parameters.AddWithValue("@RetVal", SqlDbType.NChar);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            _con.Open();


            try
            {

                command.ExecuteNonQuery();
                name1 = (string)returnParameter.Value;
                return name1;

            }
            catch (Exception ex)
            {
                return null;

            }
            finally
            {
                _con.Close();
                _con.Dispose();
            }



        }
        public static int GetTableCount(string tablename)
        {
            SqlConnection _con = new SqlConnection(constring);
            int count = 0;
            string sql1 = "SELECT COUNT(*) FROM " + tablename;
            SqlCommand command = new SqlCommand(sql1, _con);
            _con.Open();

            try
            {
                object c= command.ExecuteScalar();
                count = int.Parse(c.ToString());
                
            }
            catch (Exception ex)
            {
                return -1;
                
            }
            finally
            {
                _con.Close();
                _con.Dispose();
            }

            return count;
        }

        public static int GetContainerUnstuffStatus(int HBLID)
        {
            int rtn = 0;

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                //string sqlstr = "SELECT b.unstuff_flag FROM[dbo].[HBL] a "
                //+ "INNER JOIN[dbo].[OBL_Containers] b ON a.obl_id = b.obl_id "
                //+ "WHERE a.id = '" + HBL + "'";

                string sqlstr = "SELECT ISNULL(b.unstuff_flag,0) AS unstuff_flag FROM [dbo].[HBL_Container] a "
                                + "INNER JOIN [dbo].[OBL_Containers] b ON a.container_id = b.id WHERE a.hbl_id = "+ HBLID +"";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    rtn = Convert.ToInt32(dr["unstuff_flag"]);
                }

                dr.Close();
            }
            catch
            {
                rtn = -1;
            }
            finally
            {
                conn.Close();
            }

            return rtn;
        }

        public static int GetStorageDays(string UnstuffDate, string InvoiceDate)
        {
            int rtn = 0;

            SqlConnection conn = new SqlConnection(constring);

            try
            {

                string sqlstr = " SELECT DATEDIFF(d,'" + UnstuffDate + "','" + InvoiceDate + "') AS StorageTime ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    rtn = Convert.ToInt32(dr["StorageTime"]) + 1;
                }
                dr.Close();
            }
            catch
            {
                rtn = -1;
            }
            finally
            {
                conn.Close();
            }

            return rtn;
        }

        public static int GetClassID(int InvoiceID)
        {
            int rtn = 0;

            SqlConnection conn = new SqlConnection(constring);

            try
            {

                string sqlstr = "SELECT ISNULL(class_id,0) AS class_id FROM [dbo].[HBL] WHERE id = (SELECT hbl_id FROM [dbo].[INV] WHERE id = " + InvoiceID + ")";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    rtn = Convert.ToInt32(dr["class_id"]);
                }
                dr.Close();
            }
            catch
            {
                rtn = -1;
            }
            finally
            {
                conn.Close();
            }

            return rtn;
        }

        public static DataTable GetPartialLoadDetails(int HBLID)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_GetPartialLoadDetails", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@hbl_id", SqlDbType.Int).Value = HBLID;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static int GetContainerID(string ContainerNo)
        {
            SqlConnection conn = new SqlConnection(constring);
            int rtn = 0;

            try
            {
                string sqlstr = "SELECT ISNULL(id, 0) AS ContainerID FROM OBL_Containers WHERE container_no = '" + ContainerNo + "' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    rtn = Convert.ToInt32(dr["ContainerID"]);
                }
                dr.Close();
            }
            catch
            {
                rtn = 0;
            }
            finally
            {
                conn.Close();
            }
            
            return rtn;
        }

        public static int GetAdminFlag(int UserID)
        {
            SqlConnection conn = new SqlConnection(constring);
            int rtn = 0;

            try
            {
                string sqlstr = "SELECT ISNULL(AdmFlag, 0)AS AdmFlag FROM [dbo].[UserDetails] WHERE id = "+ UserID +"";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    rtn = Convert.ToInt32(dr["AdmFlag"]);
                }
                dr.Close();
            }
            catch
            {
                rtn = 0;
            }
            conn.Close();

            return rtn;
        }


        public static string CheckInvoiceItemExist(int InvoiceID, int ItemID)
        {
            var rtn = "N";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "SELECT item_id FROM [dbo].[INV_Items] WHERE inv_id = '" + InvoiceID + "' AND item_id = '" + ItemID + "'";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    rtn = "Y";
                }
                dr.Close();
            }
            catch
            {
                rtn = "E";
            }
            finally
            {
                conn.Close();
            }

            return rtn;
        }

        public static string CheckHBLIssuedInvoice(int HBLID)
        {
            SqlConnection conn = new SqlConnection(constring);
            var rtn = "";

            try
            {
                var command = new SqlCommand("spPIS_CheckHBLIssuedInvoice", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@hbl_id", SqlDbType.Int).Value = HBLID;

                conn.Open();

                SqlDataReader dr = command.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        rtn = dr["InvoiceIssueFlg"].ToString();
                    }
                }
                else
                {
                    rtn = "N";
                }
                dr.Close();
            }
            catch(Exception e)
            {
                rtn = e.ToString();
            }
            finally
            {
                conn.Close();
            }
            
            return rtn;
        }

        public static DataSet ValidateUser(string UserName, string Password)
        {
            SqlConnection _con = new SqlConnection(constring);
            try
            {
                DataSet ds = new DataSet();
                SqlCommand command = new SqlCommand("ValidateUser", _con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserName", SqlDbType.VarChar).Value = UserName;
                command.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = Password;
                _con.Open();

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                    return ds;
                else
                    return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                _con.Close();
                _con.Dispose();
            }
        }

        public static DataTable spMst_AdvSearchLocation()
        {
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "SELECT id, code FROM [dbo].[M_Location] ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                int count = 0;
                count = dt.Rows.Count;

                if (count >= 1)
                {
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable spMst_AdvSearchSCN(string SearchBy)
        {
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "SELECT id, scn FROM [dbo].[M_Voyage] WHERE scn LIKE '%" + SearchBy + "%' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                int count = 0;
                count = dt.Rows.Count;

                if (count >= 1)
                {
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable spMst_AdvSearchPort(string SearchBy)
        {
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "SELECT id, name FROM [dbo].[M_Port] WHERE name LIKE '%" + SearchBy + "%' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                int count = 0;
                count = dt.Rows.Count;

                if (count >= 1)
                {
                    return dt;
                }
                else
                {
                    return null;
                }

            }
            catch(Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable spMst_AdvSearchCustomer(string SearchBy)
        {
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "SELECT id, name FROM [dbo].[M_CompanyInfo] WHERE name LIKE '%" + SearchBy + "%' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                int count = 0;
                count = dt.Rows.Count;

                if (count >= 1)
                {
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable spMst_AdvSearchUnit(string SearchBy)
        {
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "SELECT id, shortname FROM [dbo].[M_Unit] WHERE shortname LIKE '%" + SearchBy + "%' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                int count = 0;
                count = dt.Rows.Count;

                if (count >= 1)
                {
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable spMst_AdvSearchVessel(string SearchBy)
        {
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "SELECT id, vid, name FROM [dbo].[M_Vessel] WHERE name LIKE '%" + SearchBy + "%' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                int count = 0;
                count = dt.Rows.Count;

                if (count >= 1)
                {
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable spMst_AdvSearchClass(string SearchBy)
        {
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "SELECT id, fullname FROM [dbo].[M_Class] WHERE fullname LIKE '%" + SearchBy + "%'";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch(Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable spMst_AdvSearchSize(string SearchBy)
        {
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "SELECT id, name FROM [dbo].[M_CSize] WHERE name LIKE '%" + SearchBy + "%' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable AdvSearchContainer(string SearchBy)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "SELECT DISTINCT(container_no), id FROM [dbo].[OBL_Containers] " 
                                + "WHERE container_no LIKE '%"+ SearchBy +"%' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable AdvSearchOceanBill(string SearchBy)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_AdvSearchOceanBill", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@SearchBy", SqlDbType.VarChar).Value = SearchBy;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable AdvSearchOBLByContainer(string ContainerNo)
        {
            SqlConnection conn = new SqlConnection(constring);
            DataTable OBL = new DataTable();

            try
            {
                string sqlstr = "SELECT b.id, b.obl_no, c.scn, c.voyage_no, d.name, c.eta, ISNULL(FORMAT(a.unstuff_date,'dd/MM/yyyy'), '') as unstuff_date "
                                + "FROM[dbo].[OBL_Containers] a "
                                + "INNER JOIN[dbo].[OBL] b ON b.id = a.obl_id "
                                + "INNER JOIN[dbo].[M_Voyage] c ON c.id = b.voyage_id "
                                + "INNER JOIN[dbo].[M_Vessel] d ON d.id = c.vessel_id "
                                + "WHERE a.container_no = '" + ContainerNo + "'";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(OBL);

            }
            catch
            {
                OBL.Reset();
            }
            finally
            {
                conn.Close();
            }

            return OBL;
        }

        public static DataTable AdvSearchHBL(int OBLID)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_AdvSearchHBL", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@ID", SqlDbType.VarChar).Value = OBLID;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable AdvSearchHBLByOBL(int OBLID, int ContainerID)
        {
            SqlConnection conn = new SqlConnection(constring);
            DataTable HBL = new DataTable();

            try
            {
                string sqlstr = "SELECT a.id, a.hbl_no, a.goods_qty,a.weight,a.volume "
                                + "FROM[dbo].[HBL] a INNER JOIN[dbo].[HBL_Container] b ON a.id = b.hbl_id "
                                + "WHERE a.obl_id = "+ OBLID +" AND container_id = "+ ContainerID +" "; 

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(HBL);
            }
            catch
            {
                HBL.Reset();
            }
            finally
            {
                conn.Close();
            }

            return HBL;
        }

        public static DataTable AdvSearchHBLByContainer(int ContID)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_AdvSearchHBLByContainer", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@cont_id", SqlDbType.VarChar).Value = ContID;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable AdvSearchHBLByUnstuffContainer(int ContID)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_AdvSearchHBLByUnstuffContainer", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@cont_id", SqlDbType.VarChar).Value = ContID;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }


        public static DataTable AdvSearchOBLContainers(int OBLID)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_AdvSearchOBLContainers", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@ID", SqlDbType.Int).Value = OBLID;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable AdvSearchHBLContainers(int ID, int OprID)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_AdvSearchHBLContainers", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                command.Parameters.Add("@Opr", SqlDbType.Int).Value = OprID;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable AdvSearchUnstuffContainer(string SearchBy, int Flag)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_AdvSearchUnstuffContainer", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@SearchBy", SqlDbType.VarChar).Value = SearchBy;
                command.Parameters.Add("@Flag", SqlDbType.TinyInt).Value = Flag;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        
        public static DataTable AdvSearchInvoiceHBL(string SearchBy)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_AdvSearchInvoiceHBL", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@SearchBy", SqlDbType.VarChar).Value = SearchBy;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable AdvSearchInvoiceConsignee(string SearchBy)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstring = "SELECT a.id, a.name FROM [dbo].[M_CompanyInfo] a WHERE a.name LIKE '%"+ SearchBy +"%'";

                var command = new SqlCommand(sqlstring, conn);

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable AdvSearchInvoiceItems(string SearchBy)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_AdvSearchInvoiceItems", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@SearchBy", SqlDbType.VarChar).Value = SearchBy;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable AdvSearchInvoiceDebit(string SearchBy)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "SELECT id, inv_no FROM [dbo].[INV] WHERE inv_no LIKE '" + SearchBy + "%'";
                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable AdvSearchInvoiceCredit(string SearchBy)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "SELECT id, inv_no FROM [dbo].[INV] WHERE inv_no LIKE '" + SearchBy + "%'";
                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable AdvSearchDebitInvoice(string SearchBy)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "SELECT a.id, a.dr_no,b.inv_no,a.dr_date FROM[dbo].[DR] a "
                                + "INNER JOIN[dbo].[INV] b ON a.inv_id = b.id WHERE dr_no LIKE '%" + SearchBy + "%'";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable AdvSearchCreditInvoice(string SearchBy)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "SELECT a.id, a.cr_no,b.inv_no,a.cr_date FROM[dbo].[CR] a "
                                + "INNER JOIN[dbo].[INV] b ON a.inv_id = b.id WHERE cr_no LIKE '%"+ SearchBy +"%'";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable AdvSearchInvoice(int SearchType, string SearchBy)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_AdvSearchInvoice", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@SearchType", SqlDbType.TinyInt).Value = SearchType;
                command.Parameters.Add("@SearchBy", SqlDbType.VarChar).Value = SearchBy;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable AdvSearchInvoiceDebit(int InvoiceID, int DebitID)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_AdvSearchInvoiceDebit", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@inv_id", SqlDbType.Int).Value = InvoiceID;
                command.Parameters.Add("@debit_id", SqlDbType.Int).Value = DebitID;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable AdvSearchInvoiceCredit(int InvoiceID, int CreditID)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_AdvSearchInvoiceCredit", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@inv_id", SqlDbType.Int).Value = InvoiceID;
                command.Parameters.Add("@credit_id", SqlDbType.Int).Value = CreditID;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable AdvSearchCFS(string SearchBy)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "SELECT a.id, a.cfs_no, b.name AS shipper, c.name AS discharge_port, d.name AS final_port, a.qty, "
                                 + "a.[weight] AS [weight], a.volume FROM [dbo].[CFS] a INNER JOIN [dbo].[M_CompanyInfo] b ON a.shipper_id = b.id "
                                 + "INNER JOIN [dbo].[M_Port] c ON a.discharge_port_id = c.id INNER JOIN [dbo].[M_Port] d ON a.final_port_id = d.id "
                                 + "WHERE a.cfs_no LIKE '%"+ SearchBy +"%'";

                var command = new SqlCommand(sqlstr, conn);
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int x = dt.Rows.Count;
                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable AdvSearchCP(int SearchMode, string SearchBy)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "SELECT a.id, a.container_no, b.scn, b.voyage_no, c.name AS vessel, d.name AS cust "
                                + "FROM[dbo].[CP] a INNER JOIN[dbo].[M_Voyage] b ON a.voyage_id = b.id "
                                + "INNER JOIN[dbo].[M_Vessel] c ON b.vessel_id = c.id INNER JOIN[dbo].[M_CompanyInfo] d ON a.cust_id = d.id ";

                string wherestr = SearchMode > 0 ? SearchMode == 1 ? "WHERE a.container_no LIKE '%" + SearchBy + "%'" : "WHERE d.name LIKE '%" + SearchBy + "%'" : "";

                sqlstr += wherestr;

                var command = new SqlCommand(sqlstr, conn);
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable spMst_AdvSearchOperator(string SearchBy)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "SELECT * FROM [dbo].[M_Operator] WHERE code LIKE '%"+ SearchBy +"%' OR liner_name LIKE'%"+ SearchBy +"%'";

                var command = new SqlCommand(sqlstr, conn);
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable AdvSearchTranshipmentHBL(string SearchBy)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "SELECT id, hbl_no FROM [dbo].[HBL] WHERE transhipment = 1 AND hbl_no LIKE '%" + SearchBy +"%'";

                var command = new SqlCommand(sqlstr, conn);
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable AdvSearchExportInvoiceCFS(string SearchBy)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = @"  SELECT
	                                    a.cp_id, a.cfs_id, b.cfs_no, b.qty AS goods_qty, b.[weight], b.volume, b.date_receive
                                    FROM 
	                                    [dbo].[CP_Items] a
                                    INNER JOIN 
	                                    [dbo].[CFS] b ON a.cfs_id = b.id 
                                    WHERE 
	                                    a.transhipment = 0
                                    AND 
	                                    b.cfs_no LIKE '%"+ SearchBy +"%'";

                var command = new SqlCommand(sqlstr, conn);
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable AdvSearchExportInvoice(string SearchBy)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "SELECT InvoiceTbl.id, InvoiceTbl.inv_no, CFSTbl.cfs_no, InvoiceTbl.goods_qty, "
                                + "InvoiceTbl.weight, InvoiceTbl.volume FROM [dbo].[EXP_Inv] InvoiceTbl "
                                + "INNER JOIN [dbo].[CFS] CFSTbl ON InvoiceTbl.cfs_id = CFSTbl.id "
                                + "WHERE InvoiceTbl.inv_no LIKE '%" + SearchBy + "%' OR CFSTbl.cfs_no LIKE '%" + SearchBy + "%'";

                var command = new SqlCommand(sqlstr, conn);
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable AdvSearchCPContainer(string SearchBy)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = @"SELECT * FROM [dbo].[CP] WHERE container_no LIKE '%" + SearchBy + "%'";

                var command = new SqlCommand(sqlstr, conn);
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable LoadVoyageDetails(string ID)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_LoadVoyageDetails", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch(Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable LoadOceanBillDetails(string OBLID)
        {
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_LoadOBL", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@ID", SqlDbType.VarChar).Value = OBLID;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch(Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable LoadOceanBillDetailsByHBL(string OBLID)
        {
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_LoadOBLByHBL", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@ID", SqlDbType.VarChar).Value = OBLID;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable LoadHBL(int HBLID)
        {
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_LoadHBL", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@ID", SqlDbType.VarChar).Value = HBLID;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable LoadOBLContainers(int ID)
        {
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_LoadOBLContainers", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@ID", SqlDbType.VarChar).Value = ID;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable LoadOBLHBL(int HBLID, int InvID, string IssueDate)
        {
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_LoadInvoiceOBLHBL", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@hbl_id", SqlDbType.VarChar).Value = HBLID;
                command.Parameters.Add("@inv_id", SqlDbType.VarChar).Value = InvID;
                command.Parameters.Add("@issue_date", SqlDbType.VarChar).Value = IssueDate;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }


        public static DataTable LoadContainerTallySheetOBLDetails(int OBLID, int ContID, int UserID)
        {
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_LoadContainerTallySheetOBLDetails", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@obl_id", SqlDbType.Int).Value = OBLID;
                command.Parameters.Add("@cont_id", SqlDbType.Int).Value = ContID;
                command.Parameters.Add("@user_id", SqlDbType.Int).Value = UserID;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable LoadInvoiceSheet(int InvID, string Amount, int UserID)
        {
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_LoadInvoiceSheet", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@inv_id", SqlDbType.Int).Value = InvID;
                command.Parameters.Add("@amount_word", SqlDbType.Text).Value = Amount;
                command.Parameters.Add("@user_id", SqlDbType.Int).Value = UserID;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable LoadCreditSheet(int CreditID, string Amount, int UserID)
        {
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_LoadCreditSheet", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@cr_id", SqlDbType.Int).Value = CreditID;
                command.Parameters.Add("@amountInWords", SqlDbType.Text).Value = Amount;
                command.Parameters.Add("@user_id", SqlDbType.Int).Value = UserID;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable LoadDebitSheet(int DebitID, string Amount, int UserID)
        {
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_LoadDebitSheet", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@dr_id", SqlDbType.Int).Value = DebitID;
                command.Parameters.Add("@amountInWords", SqlDbType.Text).Value = Amount;
                command.Parameters.Add("@user_id", SqlDbType.Int).Value = UserID;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable LoadActivityReport(int ContainerID, int UserID)
        {
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_LoadActivityRpt", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@cont_id", SqlDbType.Int).Value = ContainerID;
                command.Parameters.Add("@user_id", SqlDbType.Int).Value = UserID;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable LoadK4Report(int ContainerID, int UserID)
        {
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_LoadK4Rpt", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@cont_id", SqlDbType.Int).Value = ContainerID;
                command.Parameters.Add("@user_id", SqlDbType.Int).Value = UserID;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable LoadK4TeusReport(string DateFrom, string DateTo)
        {
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_LoadK4TeusRpt", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@date_from", SqlDbType.VarChar).Value = DateFrom;
                command.Parameters.Add("@date_to", SqlDbType.VarChar).Value = DateTo;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable LoadUncollectedCargoReport(string DateFrom, string DateTo, int AgentID)
        {
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_UncollectedCargoRpt", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@date_from", SqlDbType.VarChar).Value = DateFrom;
                command.Parameters.Add("@date_to", SqlDbType.VarChar).Value = DateTo;
                command.Parameters.Add("@agent_id", SqlDbType.Int).Value = AgentID;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable LoadARInvoiceReport(string Rpt, string DateFrom, string DateTo, int Payment, int Customer)
        {
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_LoadARInvoiceRpt", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@rpt", SqlDbType.Char).Value = Rpt;
                command.Parameters.Add("@date_from", SqlDbType.VarChar).Value = DateFrom;
                command.Parameters.Add("@date_to", SqlDbType.VarChar).Value = DateTo;
                command.Parameters.Add("@payment", SqlDbType.Int).Value = Payment;
                command.Parameters.Add("@customer", SqlDbType.Int).Value = Customer;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable LoadARDebitReport(string DebitDateFrom, string DebitDateTo, int UserID)
        {
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_LoadARDebitRpt", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@start_date", SqlDbType.VarChar).Value = DebitDateFrom;
                command.Parameters.Add("@end_date", SqlDbType.VarChar).Value = DebitDateTo;
                command.Parameters.Add("@user_id", SqlDbType.Int).Value = UserID;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable LoadARCreditReport(string CreditDateFrom, string CreditDateTo, int UserID)
        {
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_LoadARCreditRpt", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@start_date", SqlDbType.VarChar).Value = CreditDateFrom;
                command.Parameters.Add("@end_date", SqlDbType.VarChar).Value = CreditDateTo;
                command.Parameters.Add("@user_id", SqlDbType.Int).Value = UserID;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable LoadARCustReport(string InvoiceDateFrom, string InvoiceDateTo, int CustomerID, int UserID)
        {
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_LoadARInvoiceByCustomerRpt", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@start_date", SqlDbType.VarChar).Value = InvoiceDateFrom;
                command.Parameters.Add("@end_date", SqlDbType.VarChar).Value = InvoiceDateTo;
                command.Parameters.Add("@customer_id", SqlDbType.Int).Value = CustomerID;
                command.Parameters.Add("@user_id", SqlDbType.Int).Value = UserID;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static string UpsertOBL(int id, int voyage_id, string obl_no, int load_port, int unload_port, 
                                        int dest_port, int ship_agent, int obl_consignee, int uuser)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_UpsertOBL", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@voyage_id", SqlDbType.Int).Value = voyage_id;
                command.Parameters.Add("@obl_no", SqlDbType.VarChar).Value = obl_no;
                command.Parameters.Add("@load_port", SqlDbType.SmallInt).Value = load_port;
                command.Parameters.Add("@unload_port", SqlDbType.SmallInt).Value = unload_port;
                command.Parameters.Add("@dest_port", SqlDbType.SmallInt).Value = dest_port;
                command.Parameters.Add("@ship_agent", SqlDbType.Int).Value = ship_agent;
                command.Parameters.Add("@obl_consignee", SqlDbType.Int).Value = obl_consignee;
                //command.Parameters.Add("@cuser", SqlDbType.Int).Value = cuser;
                command.Parameters.Add("@uuser", SqlDbType.Int).Value = uuser;

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR" + msg.ToString();
            }
            conn.Close();

            return rtn;
        }

        public static string spPIS_UpsertHBL(int HBLID, string HBLNo, int OBLID, int ContID, string CargoDesc,
                                             int Unit, int Consignee, string Remarks, int Inward_Survey,
                                             string Marking, int Transhipment, int Port, string Packaging, string Location, 
                                             int Class, int GoodQty, decimal Weight, decimal Volume, int Uuser)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_UpsertHBL", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@hbl_id", SqlDbType.Int).Value = HBLID;
                command.Parameters.Add("@hbl_no", SqlDbType.VarChar).Value = HBLNo;
                command.Parameters.Add("@obl_id", SqlDbType.Int).Value = OBLID;
                command.Parameters.Add("@cont_id", SqlDbType.Int).Value = ContID;
                command.Parameters.Add("@cargo_desc", SqlDbType.VarChar).Value = CargoDesc;
                command.Parameters.Add("@unit_id", SqlDbType.Int).Value = Unit;
                command.Parameters.Add("@consignee_id", SqlDbType.Int).Value = Consignee;
                command.Parameters.Add("@remarks", SqlDbType.VarChar).Value = Remarks;
                command.Parameters.Add("@inward_survey", SqlDbType.TinyInt).Value = Inward_Survey;
                command.Parameters.Add("@marking", SqlDbType.VarChar).Value = Marking;
                command.Parameters.Add("@transhipment", SqlDbType.TinyInt).Value = Transhipment;
                command.Parameters.Add("@port_id", SqlDbType.Int).Value = Port;
                command.Parameters.Add("@packaging", SqlDbType.VarChar).Value = Packaging;
                command.Parameters.Add("@location", SqlDbType.VarChar).Value = Location;
                command.Parameters.Add("@class_id", SqlDbType.TinyInt).Value = Class;
                command.Parameters.Add("@goods_qty", SqlDbType.SmallInt).Value = GoodQty;
                command.Parameters.Add("@weight", SqlDbType.Decimal).Value = Weight;
                command.Parameters.Add("@volume", SqlDbType.Decimal).Value = Volume;
                command.Parameters.Add("@uuser", SqlDbType.SmallInt).Value = Uuser;

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR" + msg.ToString();
            }
            conn.Close();

            return rtn;
        }

        public static string UpdateHBLUnstuffContainer(string Marking, int Transhipment, int Port, int InwardSurvey,
                                                        string Remarks, string Packaging, string Location, int HBLID)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "UPDATE [dbo].[HBL] SET marking = '" + Marking + "', transhipment = " + Transhipment + " ,inward_survey = " + InwardSurvey + " , "
                                + "remarks = '" + Remarks + "', packaging = '" + Packaging + "', location = '"+ Location +"' ,port_id = "+ Port +" "
                                + "WHERE id = " + HBLID + "";

                var command = new SqlCommand(sqlstr, conn);
                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch(Exception e)
            {
                msg = e.Message;
                rtn = "ERROR : " + msg.ToString();
            }
            finally
            {
                conn.Close();
            }

            return rtn;
        }

        public static string UpsertOBLContainer(int ContID, int OBLID, string ContainerNo, string SealNo, int SizeID, int Type, 
                                                int Status, int Ship, int Movement, int SealParty, int Supplier,
                                                int Uuser)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_UpsertOBLContainers", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@cont_id", SqlDbType.Int).Value = ContID;
                command.Parameters.Add("@obl_id", SqlDbType.Int).Value = OBLID;
                command.Parameters.Add("@container_no", SqlDbType.VarChar).Value = ContainerNo;
                command.Parameters.Add("@seal_no", SqlDbType.VarChar).Value = SealNo;
                command.Parameters.Add("@size_id", SqlDbType.TinyInt).Value = SizeID;
                command.Parameters.Add("@type", SqlDbType.TinyInt).Value = Type;
                command.Parameters.Add("@status", SqlDbType.TinyInt).Value = Status;
                command.Parameters.Add("@ship", SqlDbType.TinyInt).Value = Ship;
                command.Parameters.Add("@movement", SqlDbType.TinyInt).Value = Movement;
                command.Parameters.Add("@seal_party", SqlDbType.TinyInt).Value = SealParty;
                command.Parameters.Add("@supplier", SqlDbType.TinyInt).Value = Supplier;
                command.Parameters.Add("@uuser", SqlDbType.SmallInt).Value = Uuser;


                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch(Exception e)
            {
                msg = e.Message;
                rtn = "ERROR : " + msg.ToString();
            }
            conn.Close();

            return rtn;
        }

        public static string DelOceanBillDetails(int OBLID)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "DELETE FROM [dbo].[OBL] WHERE id = '" + OBLID + "' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch(Exception e)
            {
                msg = e.Message;
                rtn = "ERROR";
            }
            finally
            {
                conn.Close();
            }
            return rtn;
        }

        public static string DelMstLocation(int LocID)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "DELETE FROM [dbo].[M_Location] WHERE id = '" + LocID + "' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR";
            }
            finally
            {
                conn.Close();
            }
            return rtn;
        }

        public static string DelHBL(int HBLID)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "DELETE FROM [dbo].[HBL] WHERE id = '" + HBLID + "' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR";
            }
            finally
            {
                conn.Close();
            }
            return rtn;
        }

        public static string DelOBLContainers(int ContID)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "DELETE FROM [dbo].[OBL_Containers] WHERE id = '" + ContID + "' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR";
            }
            finally
            {
                conn.Close();
            }
            return rtn;
        }

        public static string DelHBLContainers(int HBLID, int ContID)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "DELETE FROM [dbo].[HBL_Container] WHERE hbl_id = '" + HBLID + "' AND container_id = '" + ContID + "' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR";
            }
            finally
            {
                conn.Close();
            }
            return rtn;
        }

        public static string DelInvoice(int InvoiceID)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "DELETE FROM [dbo].[INV] WHERE id = '" + InvoiceID + "' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR";
            }
            finally
            {
                conn.Close();
            }
            return rtn;
        }


        public static string DelCredit(int CreditID)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "DELETE FROM [dbo].[CR] WHERE id = '" + CreditID + "' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR";
            }
            finally
            {
                conn.Close();
            }
            return rtn;
        }

        public static string DelDebit(int DebitID)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "DELETE FROM [dbo].[DR] WHERE id = '" + DebitID + "' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR";
            }
            finally
            {
                conn.Close();
            }
            return rtn;
        }

        public static string DelInvoiceItem(int ItemID)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "DELETE FROM [dbo].[INV_Items] WHERE id = '" + ItemID + "' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR";
            }
            finally
            {
                conn.Close();
            }
            return rtn;
        }

        public static string DelCreditItems(int ItemID)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "DELETE FROM [dbo].[CR_Items] WHERE id = '" + ItemID + "' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR";
            }
            finally
            {
                conn.Close();
            }
            return rtn;
        }

        public static string DelDebitItems(int ItemID)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "DELETE FROM [dbo].[DR_Items] WHERE id = '" + ItemID + "' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR";
            }
            finally
            {
                conn.Close();
            }
            return rtn;
        }

        public static string DelAllInvoiceItem(int InvoiceID)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "DELETE FROM [dbo].[INV_Items] WHERE inv_id = '" + InvoiceID + "' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR";
            }
            finally
            {
                conn.Close();
            }
            return rtn;
        }

        public static string DelAllCreditItem(int CreditID)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "DELETE FROM [dbo].[CR_Items] WHERE cr_id = '" + CreditID + "' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR";
            }
            finally
            {
                conn.Close();
            }
            return rtn;
        }

        public static string DelAllDebitItem(int DebitID)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "DELETE FROM [dbo].[DR_Items] WHERE dr_id = '" + DebitID + "' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR";
            }
            finally
            {
                conn.Close();
            }
            return rtn;
        }

        public static string DelCFS(int CFSID)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "DELETE FROM [dbo].[CFS] WHERE id = '" + CFSID + "' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR";
            }
            finally
            {
                conn.Close();
            }
            return rtn;
        }

        public static string DelCP(int CPID)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "DELETE FROM [dbo].[CP] WHERE id = '" + CPID + "' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR";
            }
            finally
            {
                conn.Close();
            }
            return rtn;
        }

        public static string DelCPItems(int CPItemsID)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "DELETE FROM [dbo].[CP_Items] WHERE id = '" + CPItemsID + "' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR";
            }
            finally
            {
                conn.Close();
            }
            return rtn;
        }

        public static string DelMstOperator(int OperatorID)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "DELETE FROM [dbo].[M_Operator] WHERE id = " + OperatorID;

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR";
            }
            finally
            {
                conn.Close();
            }
            return rtn;
        }

        public static string DelExportInvoice(int InvoiceID)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "DELETE FROM [dbo].[EXP_Inv] WHERE id = '" + InvoiceID + "' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR";
            }
            finally
            {
                conn.Close();
            }
            return rtn;
        }

        public static string DelAllExportInvoiceItem(int InvoiceID)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "DELETE FROM [dbo].[EXP_InvItem] WHERE inv_id = '" + InvoiceID + "' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR";
            }
            finally
            {
                conn.Close();
            }
            return rtn;
        }

        public static string DelExportInvoiceItem(int InvoiceItemID)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "DELETE FROM [dbo].[EXP_InvItem] WHERE id = '" + InvoiceItemID + "' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR";
            }
            finally
            {
                conn.Close();
            }
            return rtn;
        }

        public static int GetOBLID(int voyage_id)
        {
            int rtn = 0;
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "SELECT id FROM [dbo].[OBL] WHERE voyage_id = '" + voyage_id + "' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    rtn = Convert.ToInt32(dr["id"]);
                }
                dr.Close();
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = 0;
            }
            finally
            {
                conn.Close();
            }
            return rtn;
        }

        public static int GetContID(string ContainerNo)
        {
            int rtn = 0;
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "SELECT id FROM [dbo].[OBL_Containers] WHERE container_no = '" + ContainerNo + "' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    rtn = Convert.ToInt32(dr["id"]);
                }
                dr.Close();
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = 0;
            }
            finally
            {
                conn.Close();
            }
            return rtn;
        }

        public static int GetHBLID(string HBLNo)
        {
            int rtn = 0;
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "SELECT id FROM [dbo].[HBL] WHERE hbl_no = '" + HBLNo + "' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    rtn = Convert.ToInt32(dr["id"]);
                }
                dr.Close();
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = 0;
            }
            finally
            {
                conn.Close();
            }
            return rtn;
        }

        public static int GetInvoiceID(string InvoiceNo)
        {
            int rtn = 0;
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "SELECT id FROM [dbo].[INV] WHERE inv_no = '" + InvoiceNo + "' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    rtn = Convert.ToInt32(dr["id"]);
                }
                dr.Close();
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = 0;
            }
            finally
            {
                conn.Close();
            }
            return rtn;
        }

        public static int GetCreditID(string CreditNo)
        {
            int rtn = 0;
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "SELECT id FROM [dbo].[CR] WHERE cr_no = '" + CreditNo + "' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    rtn = Convert.ToInt32(dr["id"]);
                }
                dr.Close();
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = 0;
            }
            finally
            {
                conn.Close();
            }
            return rtn;
        }

        public static int GetDebitID(string DebitNo)
        {
            int rtn = 0;
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "SELECT id FROM [dbo].[DR] WHERE dr_no = '" + DebitNo + "' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    rtn = Convert.ToInt32(dr["id"]);
                }
                dr.Close();
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = 0;
            }
            finally
            {
                conn.Close();
            }
            return rtn;
        }

        public static int GetLocID(string Code)
        {
            int rtn = 0;
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "SELECT id FROM [dbo].[M_Location] WHERE code = '" + Code + "' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    rtn = Convert.ToInt32(dr["id"]);
                }
                dr.Close();
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = -1;
            }
            finally
            {
                conn.Close();
            }

            return rtn;
        }
        public static int GetCFSID(string CFSNo)
        {
            int rtn = 0;
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "SELECT id FROM [dbo].[CFS] WHERE cfs_no = '" + CFSNo + "' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    rtn = Convert.ToInt32(dr["id"]);
                }
                dr.Close();
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = 0;
            }
            finally
            {
                conn.Close();
            }
            return rtn;
        }

        public static int GetExportInvoiceIDByInvoiceNo(string InvoiceNo)
        {
            int rtn = 0;
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "SELECT id FROM [dbo].[EXP_Inv] WHERE inv_no = '" + InvoiceNo + "' ";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    rtn = Convert.ToInt32(dr["id"]);
                }
                dr.Close();
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = 0;
            }
            finally
            {
                conn.Close();
            }
            return rtn;
        }

        public static bool GetExportInvoiceIDByCFSID(int CFSID)
        {
            bool rtn = false;
            int InvoiceID = 0;
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = @"SELECT id FROM [dbo].[EXP_Inv] WHERE cfs_id = "+ CFSID +"";

                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    InvoiceID = Convert.ToInt32(dr["id"]);
                }
                dr.Close();

                rtn = InvoiceID > 0 ? true : false;
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = true;
            }
            finally
            {
                conn.Close();
            }
            return rtn;
        }


        public static string CheckContExist(int ContID, int HBLID)
        {
            var rtn = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_CheckContIDExist", conn);
                command.Parameters.Add("@container_id", SqlDbType.Int).Value = ContID;
                command.Parameters.Add("@hbl_id", SqlDbType.Int).Value = HBLID;
                command.CommandType = CommandType.StoredProcedure;

                conn.Open();

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    rtn = dr["Exist"].ToString();
                }
                dr.Close();
            }
            catch(Exception e)
            {
                rtn = e.Message;
            }
            finally
            {
                conn.Close();
            }

            return rtn;
        }

        public static string GenerateInvoiceNo(string IssuePort)
        {
            var rtn = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_GenerateInvoiceNo", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@issue_port", SqlDbType.Char).Value = IssuePort;

                conn.Open();

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    rtn = dr["InvoiceNo"].ToString();
                }
                dr.Close();
            }
            catch (Exception e)
            {
                
                rtn = "";
            }
            finally
            {
                conn.Close();
            }

            return rtn;
        }

        public static string GenerateCreditNo(string IssuePort)
        {
            var rtn = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_GenerateCreditNo", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@issue_port", SqlDbType.Char).Value = IssuePort;

                conn.Open();

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    rtn = dr["CreditNo"].ToString();
                }
                dr.Close();
            }
            catch (Exception e)
            {
                rtn = "";
            }
            finally
            {
                conn.Close();
            }

            return rtn;
        }

        public static string GenerateDebitNo(string IssuePort)
        {
            var rtn = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_GenerateDebitNo", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@issue_port", SqlDbType.Char).Value = IssuePort;

                conn.Open();

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    rtn = dr["DebitNo"].ToString();
                }
                dr.Close();
            }
            catch (Exception e)
            {
                rtn = "";
            }
            finally
            {
                conn.Close();
            }

            return rtn;
        }

        public static string GenerateCFSNo(string IssuePort)
        {
            var rtn = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_GenerateCFSNo", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@issue_port", SqlDbType.Char).Value = IssuePort;

                conn.Open();

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    rtn = dr["CFSNo"].ToString();
                }
                dr.Close();
            }
            catch (Exception e)
            {
                rtn = "";
            }
            finally
            {
                conn.Close();
            }

            return rtn;
        }

        public static string GenerateExportInvoiceNo(string IssuePort)
        {
            var rtn = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_GenerateExportInvoiceNo", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@issue_port", SqlDbType.Char).Value = IssuePort;

                conn.Open();

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    rtn = dr["InvoiceNo"].ToString();
                }
                dr.Close();
            }
            catch (Exception e)
            {

                rtn = "";
            }
            finally
            {
                conn.Close();
            }

            return rtn;
        }

        public static string UpsertMstLocation(int LocID, string Code, int Port)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_UpsertMstLocation", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id", SqlDbType.Int).Value = LocID;
                command.Parameters.Add("@code", SqlDbType.VarChar).Value = Code;
                command.Parameters.Add("@port", SqlDbType.TinyInt).Value = Port;

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR : " + msg.ToString();
            }
            conn.Close();

            return rtn;
        }

        public static string UpsertHBLContainers(int ContID, int HBLID)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_UpserHBLContainers", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@container_id", SqlDbType.Int).Value = ContID;
                command.Parameters.Add("@hbl_id", SqlDbType.Int).Value = HBLID;
            
                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR : " + msg.ToString();
            }
            conn.Close();

            return rtn;
        }

        public static string UpsertInvoice(int ID, string InvNo, DateTime InvDate, string IIDNo, int PaymentMethod, string RefNo,
                                            int HBLID, int ConsigneeID, string Qty, decimal Weight, decimal Volume, bool Partial, int StorageDays, int Uuser)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_UpsertInvoice", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                command.Parameters.Add("@inv_no", SqlDbType.VarChar).Value = InvNo;
                command.Parameters.Add("@inv_date", SqlDbType.SmallDateTime).Value = InvDate;
                command.Parameters.Add("@iid_no", SqlDbType.VarChar).Value = IIDNo;
                command.Parameters.Add("@payment_method", SqlDbType.TinyInt).Value = PaymentMethod;
                command.Parameters.Add("@ref_no", SqlDbType.VarChar).Value = RefNo;
                command.Parameters.Add("@hbl_id", SqlDbType.Int).Value = HBLID;
                command.Parameters.Add("@consignee_id", SqlDbType.Int).Value = ConsigneeID;
                command.Parameters.Add("@goods_qty", SqlDbType.Real).Value = Qty;
                command.Parameters.Add("@weight", SqlDbType.Decimal).Value = Weight;
                command.Parameters.Add("@volume", SqlDbType.Decimal).Value = Volume;
                command.Parameters.Add("@partial", SqlDbType.Bit).Value = Partial;
                command.Parameters.Add("@storage_days", SqlDbType.Int).Value = StorageDays;
                command.Parameters.Add("@uuser", SqlDbType.TinyInt).Value = Uuser;

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR : " + msg.ToString();
            }
            conn.Close();

            return rtn;
        }

        public static string UpsertCredit(int CreditID, string CreditNo, int InvoiceID, int Uuser)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_UpsertCredit", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id", SqlDbType.Int).Value = CreditID;
                command.Parameters.Add("@cr_no", SqlDbType.VarChar).Value = CreditNo;
                command.Parameters.Add("@inv_id", SqlDbType.Int).Value = InvoiceID;
                command.Parameters.Add("@uuser", SqlDbType.TinyInt).Value = Uuser;

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR : " + msg.ToString();
            }
            conn.Close();

            return rtn;
        }

        public static string UpsertDebit(int DebitID, string DebitNo, int InvoiceID, int Payment, string RefNo,  int Uuser)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_UpsertDebit", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id", SqlDbType.Int).Value = DebitID;
                command.Parameters.Add("@dr_no", SqlDbType.VarChar).Value = DebitNo;
                command.Parameters.Add("@inv_id", SqlDbType.Int).Value = InvoiceID;
                command.Parameters.Add("@payment", SqlDbType.TinyInt).Value = Payment;
                command.Parameters.Add("@ref_no", SqlDbType.VarChar).Value = RefNo;
                command.Parameters.Add("@uuser", SqlDbType.TinyInt).Value = Uuser;

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR : " + msg.ToString();
            }
            conn.Close();

            return rtn;
        }

        public static string UpdateUnstuffContainer(int ContID, bool Unstuff, DateTime UnstuffDate)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_UpdateUnstuffContainer", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@cont_id", SqlDbType.Int).Value = ContID;
                command.Parameters.Add("@unstuff_flag", SqlDbType.Bit).Value = Unstuff;
                command.Parameters.Add("@unstuff_date", SqlDbType.SmallDateTime).Value = UnstuffDate;

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR : " + msg.ToString();
            }
            conn.Close();

            return rtn;
        }

        public static string UpsertInvoiceItems(int ID, int InvID, int ItemID, int Qty, decimal UnitPrice,
                                                        decimal Amount, int Uuser)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_UpsertInvoiceItems", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                command.Parameters.Add("@inv_id", SqlDbType.Int).Value = InvID;
                command.Parameters.Add("@item_id", SqlDbType.TinyInt).Value = ItemID;
                command.Parameters.Add("@qty", SqlDbType.Int).Value = Qty;
                command.Parameters.Add("@unit_price", SqlDbType.Decimal).Value = UnitPrice;
                command.Parameters.Add("@amount", SqlDbType.Decimal).Value = Amount;
                command.Parameters.Add("@uuser", SqlDbType.TinyInt).Value = Uuser;

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR : " + msg.ToString();
            }
            conn.Close();

            return rtn;
        }

        public static string UpsertDebitItems(int ID, int DebitID, int ItemID, int Qty, decimal UnitPrice, decimal Amount, int Uuser)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_UpsertDebitItems", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                command.Parameters.Add("@dr_id", SqlDbType.Int).Value = DebitID;
                command.Parameters.Add("@item_id", SqlDbType.Int).Value = ItemID;
                command.Parameters.Add("@qty", SqlDbType.Int).Value = Qty;
                command.Parameters.Add("@unit_price", SqlDbType.Decimal).Value = UnitPrice;
                command.Parameters.Add("@amount", SqlDbType.Decimal).Value = Amount;
                command.Parameters.Add("@uuser", SqlDbType.TinyInt).Value = Uuser;

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR : " + msg.ToString();
            }
            conn.Close();

            return rtn;
        }

        public static string UpsertCreditItems(int ID, int CreditID, int ItemID, int Qty, decimal UnitPrice, decimal Amount, int Uuser)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_UpsertCreditItems", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                command.Parameters.Add("@cr_id", SqlDbType.Int).Value = CreditID;
                command.Parameters.Add("@item_id", SqlDbType.Int).Value = ItemID;
                command.Parameters.Add("@qty", SqlDbType.Int).Value = Qty;
                command.Parameters.Add("@unit_price", SqlDbType.Decimal).Value = UnitPrice;
                command.Parameters.Add("@amount", SqlDbType.Decimal).Value = Amount;
                command.Parameters.Add("@uuser", SqlDbType.TinyInt).Value = Uuser;

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR : " + msg.ToString();
            }
            conn.Close();

            return rtn;
        }

        public static string UpsertCFS(int ID, string CFSNo, int ShipperID, int DischargePortID, int FinalPortID, int VesselID, int Qty,
                                       int UnitID, decimal Weight, decimal Volume, string Marking, string CargoDesc, DateTime DateReceive,
                                       DateTime TimeReceive, string ReceiveBy, string Location, string ReferenceNo, string Remarks, int Uuser)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_UpsertCFS", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                command.Parameters.Add("@cfs_no", SqlDbType.VarChar).Value = CFSNo;
                command.Parameters.Add("@shipper_id", SqlDbType.Int).Value = ShipperID;
                command.Parameters.Add("@discharge_port_id", SqlDbType.Int).Value = DischargePortID;
                command.Parameters.Add("@final_port_id", SqlDbType.Int).Value = FinalPortID;
                command.Parameters.Add("@vessel_id", SqlDbType.Int).Value = VesselID;
                command.Parameters.Add("@qty", SqlDbType.Int).Value = Qty;
                command.Parameters.Add("@unit_id", SqlDbType.SmallInt).Value = UnitID;
                command.Parameters.Add("@weight", SqlDbType.Decimal).Value = Weight;
                command.Parameters.Add("@volume", SqlDbType.Decimal).Value = Volume;
                command.Parameters.Add("@marking", SqlDbType.VarChar).Value = Marking;
                command.Parameters.Add("@cargo_desc", SqlDbType.VarChar).Value = CargoDesc;
                command.Parameters.Add("@date_receive", SqlDbType.SmallDateTime).Value = DateReceive;
                command.Parameters.Add("@time_receive", SqlDbType.SmallDateTime).Value = TimeReceive;
                command.Parameters.Add("@receive_by", SqlDbType.VarChar).Value = ReceiveBy;
                command.Parameters.Add("@location", SqlDbType.VarChar).Value = Location;
                command.Parameters.Add("@reference_no", SqlDbType.VarChar).Value = ReferenceNo;
                command.Parameters.Add("@remarks", SqlDbType.VarChar).Value = Remarks;
                command.Parameters.Add("@uuser", SqlDbType.TinyInt).Value = Uuser;

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR : " + msg.ToString();
            }
            conn.Close();

            return rtn;
        }

        public static int UpsertCP(int ID, int PkgType, int CustID, int VoyageID, DateTime Eta, DateTime ClosingTime,
                                      string BookingRef, int DestID, string ContainerNo, int SizeID, int ShipType, string Location, int OprID,
                                      int Vgm, int Gang, int Terminal, string SealNo, string K8No, int MtPointID, int LedgerAcc, DateTime PackDate,
                                      string CargoPackBy, string TallyPackBy, string CheckBy, int IssueInvoice, int Uuser)
        {
            int rtn = 0;
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_UpsertCP", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                command.Parameters.Add("@pkg_type", SqlDbType.TinyInt).Value = PkgType;
                command.Parameters.Add("@cust_id", SqlDbType.Int).Value = CustID;
                command.Parameters.Add("@voyage_id", SqlDbType.Int).Value = VoyageID;
                command.Parameters.Add("@eta", SqlDbType.SmallDateTime).Value = Eta;
                command.Parameters.Add("@closing_time", SqlDbType.SmallDateTime).Value = ClosingTime;
                command.Parameters.Add("@booking_ref", SqlDbType.VarChar).Value = BookingRef;
                command.Parameters.Add("@dest_id", SqlDbType.Int).Value = DestID;
                command.Parameters.Add("@container_no", SqlDbType.VarChar).Value = ContainerNo;
                command.Parameters.Add("@size_id", SqlDbType.Int).Value = SizeID;
                command.Parameters.Add("@ship_type", SqlDbType.TinyInt).Value = ShipType;
                command.Parameters.Add("@location", SqlDbType.VarChar).Value = Location;
                command.Parameters.Add("@opr_id", SqlDbType.Int).Value = OprID;
                command.Parameters.Add("@vgm", SqlDbType.TinyInt).Value = Vgm;
                command.Parameters.Add("@gang", SqlDbType.TinyInt).Value = Gang;
                command.Parameters.Add("@terminal", SqlDbType.TinyInt).Value = Terminal;
                command.Parameters.Add("@seal_no", SqlDbType.VarChar).Value = SealNo;
                command.Parameters.Add("@k8_no", SqlDbType.VarChar).Value = K8No;
                command.Parameters.Add("@mt_point_id", SqlDbType.Int).Value = MtPointID;
                command.Parameters.Add("@ledger_acc", SqlDbType.TinyInt).Value = LedgerAcc;
                command.Parameters.Add("@pack_date", SqlDbType.SmallDateTime).Value = PackDate;
                command.Parameters.Add("@cargo_pack_by", SqlDbType.VarChar).Value = CargoPackBy;
                command.Parameters.Add("@tally_pack_by", SqlDbType.VarChar).Value = TallyPackBy;
                command.Parameters.Add("@check_by", SqlDbType.VarChar).Value = CheckBy;
                command.Parameters.Add("@issue_invoice", SqlDbType.TinyInt).Value = IssueInvoice;
                command.Parameters.Add("@uuser", SqlDbType.SmallInt).Value = Uuser;

                conn.Open();

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    rtn = Convert.ToInt32(dr["CPID"]);
                }
                dr.Close();

            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = -1;
            }
            conn.Close();

            return rtn;
        }

        public static string UpsertCPItems(int ID, int CPID, int CFSID, int Transhipment, int Uuser)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_UpsertCPItems", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                command.Parameters.Add("@cp_id", SqlDbType.Int).Value = CPID;
                command.Parameters.Add("@cfs_id", SqlDbType.Int).Value = CFSID;
                command.Parameters.Add("@transhipment", SqlDbType.TinyInt).Value = Transhipment;
                command.Parameters.Add("@uuser", SqlDbType.SmallInt).Value = Uuser;

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR : " + e.ToString().Trim();
            }
            conn.Close();

            return rtn;
        }

        public static int UpsertMstOperator(string OperatorCode, string LinerName)
        {
            int rtn = 0;
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "INSERT INTO [dbo].[M_Operator](code, liner_name) VALUES('"+ OperatorCode +"', '"+ LinerName +"') SELECT SCOPE_IDENTITY() AS OperatorID";

                var command = new SqlCommand(sqlstr, conn);
                conn.Open();

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    rtn = Convert.ToInt32(dr["OperatorID"]);
                }
                dr.Close();
            }
            catch (Exception e)
            {
                msg = e.ToString();
                rtn = -1;
            }
            conn.Close();

            return rtn;
        }

        public static string UpdateMstOperator(int OperatorID, string OperatorCode, string LinerName)
        {
            string rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "UPDATE [dbo].[M_Operator] SET code = '" + OperatorCode + "', liner_name = '"+ LinerName +"' WHERE id =" + OperatorID;

                var command = new SqlCommand(sqlstr, conn);
                conn.Open();
                command.ExecuteNonQuery();
                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.ToString();
                rtn = "ERROR: " + e.ToString();
            }
            conn.Close();

            return rtn;
        }

        public static string UpsertExportInvoice(int ID, string InvoiceNo, int CFSID, int CPID, int GoodsQty,
                                                 decimal Weight, decimal Volume, int StorageDays, int BillToID, int PaymentMethod,
                                                 DateTime DateReceive, DateTime DatePack, int Uuser)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_UpsertExportInvoice", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                command.Parameters.Add("@inv_no", SqlDbType.VarChar).Value = InvoiceNo;
                command.Parameters.Add("@cfs_id", SqlDbType.Int).Value = CFSID;
                command.Parameters.Add("@cp_id", SqlDbType.Int).Value = CPID;
                command.Parameters.Add("@goods_qty", SqlDbType.Real).Value = GoodsQty;
                command.Parameters.Add("@weight", SqlDbType.Decimal).Value = Weight;
                command.Parameters.Add("@volume", SqlDbType.Decimal).Value = Volume;
                command.Parameters.Add("@storage_days", SqlDbType.Int).Value = StorageDays;
                command.Parameters.Add("@consignee_id", SqlDbType.Int).Value = BillToID;
                command.Parameters.Add("@payment_method", SqlDbType.TinyInt).Value = PaymentMethod;
                command.Parameters.Add("@date_receive", SqlDbType.SmallDateTime).Value = DateReceive;
                command.Parameters.Add("@pack_date", SqlDbType.SmallDateTime).Value = DatePack;
                command.Parameters.Add("@uuser", SqlDbType.TinyInt).Value = Uuser;

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR : " + msg.ToString();
            }
            conn.Close();

            return rtn;
        }

        public static string UpsertExportInvoiceItems(int ID, int InvID, int ItemID, int Qty, decimal UnitPrice, decimal Amount, int Uuser)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_UpsertExportInvoiceItems", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                command.Parameters.Add("@inv_id", SqlDbType.Int).Value = InvID;
                command.Parameters.Add("@item_id", SqlDbType.TinyInt).Value = ItemID;
                command.Parameters.Add("@qty", SqlDbType.Int).Value = Qty;
                command.Parameters.Add("@unit_price", SqlDbType.Decimal).Value = UnitPrice;
                command.Parameters.Add("@amount", SqlDbType.Decimal).Value = Amount;
                command.Parameters.Add("@uuser", SqlDbType.TinyInt).Value = Uuser;

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR : " + msg.ToString();
            }
            conn.Close();

            return rtn;
        }

        public static string UpdateExportInvoiceTotalAmountWords(int InvoiceID, string TotalAmountStr)
        {
            var rtn = "";
            var msg = "";

            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = @"UPDATE [dbo].[EXP_Inv] SET amount_words = '" + TotalAmountStr + "' WHERE id = " + InvoiceID + "";
                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                command.ExecuteNonQuery();

                rtn = "OK";
            }
            catch (Exception e)
            {
                msg = e.Message;
                rtn = "ERROR : " + msg.ToString();
            }
            finally
            {
                conn.Close();
            }

            return rtn;
        }

        public static DataTable LoadMstLocation(int LocID)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "SELECT id, code, port FROM [dbo].M_Location WHERE id = " + LocID + "";
                var command = new SqlCommand(sqlstr, conn);

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                int count = 0;
                count = dt.Rows.Count;

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable LoadHBLContainers(int HBLID)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_LoadHBLContainer", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@hbl_id", SqlDbType.Int).Value = HBLID;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable LoadUnstuffContainers(int ContID)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_LoadUnstuffContainers", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@cont_id", SqlDbType.Int).Value = ContID;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable LoadInvoice(int InvoiceID)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_LoadInvoice", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id", SqlDbType.Int).Value = InvoiceID;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable LoadCredit(int CreditID)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_LoadCredit", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id", SqlDbType.Int).Value = CreditID;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable LoadDebit(int DebitID)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_LoadDebit", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id", SqlDbType.Int).Value = DebitID;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable LoadInvoiceItems(int InvoiceID)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_LoadInvoiceItems", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@inv_id", SqlDbType.Int).Value = InvoiceID;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable LoadDebitItems(int DebitID)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_LoadDebitItems", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@dr_id", SqlDbType.Int).Value = DebitID;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable LoadCreditItems(int CreditID)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_LoadCreditItems", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@cr_id", SqlDbType.Int).Value = CreditID;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable LoadCFS(int CFSID)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_LoadCFS", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id", SqlDbType.Int).Value = CFSID;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable LoadCP(int CPID)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_LoadCP", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id", SqlDbType.Int).Value = CPID;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable LoadCPItems(int CPID)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                var command = new SqlCommand("spPIS_LoadCPItems", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@cp_id", SqlDbType.Int).Value = CPID;

                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable LoadMstOperator(int OperatorID)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = "SELECT * FROM [dbo].[M_Operator] WHERE id = " + OperatorID;
                var command = new SqlCommand(sqlstr, conn);
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable LoadCFSCP(int CFSID)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = @"  SELECT
	                                    CPTbl.id, CFSTbl.cfs_id, CFSTbl.cfs_no, CPTbl.voyage_id, VoyageTbl.vessel_id, VoyageTbl.scn, VesselTbl.name AS vessel, VoyageTbl.voyage_no,
                                        CFSTbl.goods_qty, CFSTbl.weight, CFSTbl.volume, CPTbl.opr_id, OperatorTbl.code AS operator, CFSTbl.date_receive, CPTbl.pack_date,
                                        CPTbl.container_no, CPTbl.dest_id, PortTbl.name AS destination_port, CPTbl.cust_id, CompanyTbl.name AS customer, CPTbl.issue_invoice,
                                        (DATEDIFF(d, CFSTbl.date_receive, CPTbl.pack_date) + 1) AS storage_days
                                    FROM
	                                    [dbo].[CP] CPTbl
                                    INNER JOIN
	                                    ( 
		                                    SELECT a.cp_id, a.cfs_id, b.cfs_no, b.qty AS goods_qty, b.[weight], b.volume, b.date_receive
                                            FROM [dbo].[CP_Items] a INNER JOIN [dbo].[CFS] b ON a.cfs_id = b.id WHERE a.transhipment = 0 
                                            --UNION
                                            --SELECT a.cp_id, a.cfs_id, b.hbl_no AS cfs_no, b.goods_qty, b.[weight], b.volume, d.unstuff_date AS date_receive
                                            --FROM [dbo].[CP_Items] a INNER JOIN [dbo].[HBL] b ON a.cfs_id = b.id INNER JOIN  [dbo].[HBL_Container] c on b.id = c.hbl_id
                                            --INNER JOIN [dbo].[OBL_Containers] d on c.container_id = d.id WHERE a.transhipment = 1
	                                    ) AS CFSTbl ON CPTbl.id = CFSTbl.cp_id
                                    INNER JOIN
	                                    [dbo].[M_Voyage] VoyageTbl ON CPTbl.voyage_id = VoyageTbl.id
                                    INNER JOIN
	                                    [dbo].[M_Vessel] VesselTbl ON VoyageTbl.vessel_id = VesselTbl.id
                                    INNER JOIN
	                                    [dbo].[M_Port] PortTbl ON CPTbl.dest_id = PortTbl.id
                                    INNER JOIN
	                                    [dbo].[M_CompanyInfo] CompanyTbl ON CPTbl.cust_id = CompanyTbl.id
                                    INNER JOIN 
	                                    [dbo].[M_Operator] OperatorTbl ON CPTbl.opr_id = OperatorTbl.id 
                                    WHERE
	                                    CFSTbl.cfs_id = " + CFSID +"";

                var command = new SqlCommand(sqlstr, conn);
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable LoadExportInvoice(int InvoiceID)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = @"  SELECT 
	                                    InvoiceTbl.id, InvoiceTbl.cfs_id, InvoiceTbl.cp_id, InvoiceTbl.inv_no, InvoiceTbl.inv_date,
	                                    CFSTbl.cfs_no, VoyageTbl.scn, VesselTbl.name AS vessel, VoyageTbl.voyage_no, CPTbl.container_no,
	                                    PortTbl.name AS destination_port, CustomerTbl.name AS customer, InvoiceTbl.goods_qty,
	                                    InvoiceTbl.weight, InvoiceTbl.volume, OperatorTbl.code AS operator, InvoiceTbl.date_receive,
	                                    InvoiceTbl.pack_date, InvoiceTbl.storage_days, BillToTbl.name AS billTo, PortTbl.special_storage_days,
                                        ISNULL(InvoiceItemTbl.TotalAmount, 0.00) AS TotalAmount, InvoiceTbl.amount_words, InvoiceTbl.payment_method
                                    FROM 
	                                    [dbo].[EXP_Inv] InvoiceTbl
                                    INNER JOIN 
	                                    [dbo].[CFS] CFSTbl ON InvoiceTbl.cfs_id = CFSTbl.id
                                    INNER JOIN 
	                                    [dbo].[CP] CPTbl ON InvoiceTbl.cp_id = CPTbl.id
                                    INNER JOIN 
	                                    [dbo].[M_Voyage] VoyageTbl ON CPTbl.voyage_id = VoyageTbl.id
                                    INNER JOIN 
	                                    [dbo].[M_Vessel] VesselTbl ON VoyageTbl.vessel_id = VesselTbl.id
                                    INNER JOIN 
	                                    [dbo].[M_Port] PortTbl ON CPTbl.dest_id = PortTbl.id
                                    INNER JOIN 
	                                    [dbo].[M_CompanyInfo] CustomerTbl ON CPTbl.cust_id = CustomerTbl.id
                                    INNER JOIN 
	                                    [dbo].[M_Operator] OperatorTbl ON CPTbl.opr_id = OperatorTbl.id
                                    INNER JOIN 
	                                    [dbo].[M_CompanyInfo] BillToTbl ON InvoiceTbl.consignee_id = BillToTbl.id
                                    LEFT JOIN
	                                    (SELECT inv_id, SUM(amount) AS TotalAmount FROM [dbo].[EXP_InvItem] GROUP BY inv_id) InvoiceItemTbl ON InvoiceTbl.id = InvoiceItemTbl.inv_id 
                                    WHERE 
	                                    InvoiceTbl.id = " + InvoiceID +"";

                var command = new SqlCommand(sqlstr, conn);
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable LoadExportInvoiceItems(int InvoiceID)
        {
            var msg = "";
            SqlConnection conn = new SqlConnection(constring);

            try
            {
                string sqlstr = @"  SELECT 
	                                    a.id, a.item_id, b.name, a.qty, a.unit_price, a.amount
                                    FROM
	                                    [dbo].[EXP_InvItem] a
                                    INNER JOIN
	                                    [dbo].[M_ItemCode] b ON a.item_id = b.id
                                    WHERE
	                                    a.inv_id = "+ InvoiceID +"";

                var command = new SqlCommand(sqlstr, conn);
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception e)
            {
                msg = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
