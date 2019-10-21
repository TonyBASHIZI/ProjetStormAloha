using MySql.Data.MySqlClient;
using ProjetStormAloha.Classes.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProjetStormAloha.Classes
{
    public class Glossaire
    {
        private MySqlDataAdapter adapter = null;

        private static Glossaire _instance = null;

        public Glossaire()
        {
            InitializeConnection();
        }

        public static Glossaire Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Glossaire();
                return _instance;
            }
        }

        #region Common

        public void InitializeConnection()
        {
            try
            {
                Connection.Connection.Instance.Connect();

                if (Connection.Connection.Instance.Con.State == ConnectionState.Closed)
                    Connection.Connection.Instance.Con.Open();

            }
            catch (Exception ex)
            {
                throw new Exception("Echec de connexion. \n" + ex.Message);
            }
        }

        private void SetParameter(IDbCommand cmd, string name, DbType type, int length, object value)
        {
            IDbDataParameter param = cmd.CreateParameter();

            param.ParameterName = name;
            param.DbType = type;
            param.Size = length;

            if (value == null)
            {
                if (!param.IsNullable)
                {
                    param.DbType = DbType.String;
                }

                param.Value = DBNull.Value;
            }
            else
            {
                param.Value = value;
            }

            cmd.Parameters.Add(param);
        }

        public DataSet LoadDatas(string table, string orderBy = " ", string where = " ", string value = null, string like = null)
        {
            using (IDbCommand cmd = Connection.Connection.Instance.Con.CreateCommand())
            {
                DataSet ds = new DataSet();

                if (orderBy == " ")
                {
                    if (where == " " && value == null)
                    {
                        cmd.CommandText = "SELECT * FROM `storm_sport_db`.`" + table + "`; ";

                        SetParameter(cmd, "@table", DbType.String, 30, table);

                        using (adapter = new MySqlDataAdapter((MySqlCommand)cmd))
                        {
                            adapter.Fill(ds);
                        }
                    }
                    else if (where == " " && value == null && like != null)
                    {
                        cmd.CommandText = cmd.CommandText = "SELECT * FROM `storm_sport_db`.`" + table + "` WHERE " + where + " = '" + value + "' AND " + like + " ; ";

                        using (adapter = new MySqlDataAdapter((MySqlCommand)cmd))
                        {
                            adapter.Fill(ds);
                        }
                    }
                    else
                    {
                        cmd.CommandText = cmd.CommandText = "SELECT * FROM `storm_sport_db`.`" + table + "` WHERE " + where + " = '" + value + "' ; ";

                        using (adapter = new MySqlDataAdapter((MySqlCommand)cmd))
                        {
                            adapter.Fill(ds);
                        }
                    }

                }
                else
                {
                    cmd.CommandText = "SELECT * FROM `storm_sport_db`.`" + table + "` ORDER BY `" + orderBy + "` DESC";

                    using (adapter = new MySqlDataAdapter((MySqlCommand)cmd))
                    {
                        adapter.Fill(ds);
                    }
                }

                return ds;
            }
        }

        public void LoadCombos(string field, string table, ComboBox combo)
        {
            combo.Items.Clear();

            using (IDbCommand cmd = Connection.Connection.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "SELECT `" + field + "` FROM `storm_sport_db`.`" + table + "` ORDER BY `" + field + "` ";

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    combo.Items.Add(dr[field]).ToString();
                }

                dr.Dispose();
                dr.Close();
            }
        }

        public List<string> LoadString(string field, string table)
        {
            List<string> list = new List<string>();

            using (IDbCommand cmd = Connection.Connection.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "SELECT `" + field + "` FROM `storm_sport_db`.`" + table + "` ORDER BY `" + field + "` ";

                IDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    list.Add(dr[field].ToString());
                }

                dr.Dispose();
                dr.Close();
            }

            return list;
        }

        public int SelectId(string table, string field)
        {
            int id = 0;

            using (IDbCommand cmd = Connection.Connection.Instance.Con.CreateCommand())
            {
                if (field.Contains("'"))
                {
                    int index = field.IndexOf("'");
                    field = field.Insert(index + 1, "'");
                }

                cmd.CommandText = "SELECT id FROM " + table + " WHERE designation = '" + field + "'";

                IDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    id = Convert.ToInt32(dr["id"].ToString());
                }

                dr.Dispose();
                dr.Close();
            }

            return id;
        }

        public int SelectId(string table, string field, string value)
        {
            int id = 0;

            using (IDbCommand cmd = Connection.Connection.Instance.Con.CreateCommand())
            {
                if (field.Contains("'"))
                {
                    int index = field.IndexOf("'");
                    field = field.Insert(index + 1, "'");
                }

                cmd.CommandText = "SELECT id FROM `storm_sport_db`.`" + table + "` WHERE `" + field + "` = `" + value + "`";

                IDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    id = Convert.ToInt32(dr["id"].ToString());
                }

                dr.Dispose();
                dr.Close();
            }

            return id;
        }

        public void Delete(string table, int id)
        {
            using (IDbCommand cmd = Connection.Connection.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "DELETE FROM `storm_sport_db`.`" + table + "` WHERE id = @id ;";

                SetParameter(cmd, "@id", DbType.Int32, 4, id);

                int record = cmd.ExecuteNonQuery();

                if (record == 0)
                    throw new InvalidOperationException("Cet identifiante n'existe pas.");
            }
        }

        #endregion

        #region Model

        public void InsertUpdateCarte(Carte carte)
        {
            using (IDbCommand cmd = Connection.Connection.Instance.Con.CreateCommand())
            {
                if (carte.Id == 0)
                {
                    cmd.CommandText = "INSERT INTO `storm_sport_db`.`carte` (`designation`,`matricule`,`etat`) " +
                        " VALUES (@designation,@matricule,@etat); ";

                    SetParameter(cmd, "@designation", DbType.String, 255, carte.Designation);
                    SetParameter(cmd, "@matricule", DbType.String, 255, carte.Matricule);
                    SetParameter(cmd, "@etat", DbType.String, 10, carte.Etat);
                }
                else
                {
                    cmd.CommandText = "UPDATE `storm_sport_db`.`carte` SET `designation` = @designation, " + 
                        " `matricule` = @matricule, `etat` = @etat WHERE `id` = @id; ";

                    SetParameter(cmd, "@id", DbType.Int32, 10, carte.Id);
                    SetParameter(cmd, "@designation", DbType.String, 255, carte.Designation);
                    SetParameter(cmd, "@matricule", DbType.String, 255, carte.Matricule);
                    SetParameter(cmd, "@etat", DbType.String, 10, carte.Etat);
                }

                cmd.ExecuteNonQuery();
            }
        }

        public void InsertUpdateCompte(Compte cmpt)
        {
            using (IDbCommand cmd = Connection.Connection.Instance.Con.CreateCommand())
            {
                if (cmpt.Id == 0)
                {
                    cmd.CommandText = "INSERT INTO `storm_sport_db`.`compte` (`designation`,`numero_compte`) " +
                        " VALUES (@designation,@numero_compte); ";

                    SetParameter(cmd, "@designation", DbType.String, 255, cmpt.Designation);
                    SetParameter(cmd, "@numero_compte", DbType.String, 255, cmpt.Numero);
                }
                else
                {
                    cmd.CommandText = "UPDATE `storm_sport_db`.`compte` SET `designation` = @designation, " + 
                        " `numero_compte` = @numero_compte WHERE `id` = @id; ";

                    SetParameter(cmd, "@id", DbType.Int32, 10, cmpt.Id);
                    SetParameter(cmd, "@designation", DbType.String, 255, cmpt.Designation);
                    SetParameter(cmd, "@numero_compte", DbType.String, 255, cmpt.Numero);
                }

                cmd.ExecuteNonQuery();
            }
        }

        public void InsertUpdateDetailCompte(DetailCompte dcmpt)
        {
            using (IDbCommand cmd = Connection.Connection.Instance.Con.CreateCommand())
            {
                if (dcmpt.Id == 0)
                {
                    cmd.CommandText = "INSERT INTO `storm_sport_db`.`detail_compte` (`ref_compte`,`nom_societe`, " + 
                        " `telephone`,`addresse_societe`,`numero_rccm`,`email`) VALUES (@ref_compte, @nom_societe, " + 
                        " @telephone, @addresse_societe, @numero_rccm, @email); ";

                    SetParameter(cmd, "@ref_compte", DbType.String, 255, dcmpt.RefCompte);
                    SetParameter(cmd, "@nom_societe", DbType.String, 255, dcmpt.NomSociete);
                    SetParameter(cmd, "@telephone", DbType.String, 100, dcmpt.Telephone);
                    SetParameter(cmd, "@addresse_societe", DbType.String, 100, dcmpt.Adresse);
                    SetParameter(cmd, "@numero_rccm", DbType.String, 100, dcmpt.NumeroRCCM);
                    SetParameter(cmd, "@email", DbType.String, 255, dcmpt.EmailProfessionnel);
                }
                else
                {
                    cmd.CommandText = "UPDATE `storm_sport_db`.`detail_compte` SET `ref_compte` = @ref_compte, " + 
                        " `nom_societe` = @nom_societe, `telephone` = @telephone, `addresse_societe` = @addresse_societe, " +
                        " `numero_rccm` = @numero_rccm, `email` = @email WHERE `id` = @id; ";

                    SetParameter(cmd, "@id", DbType.Int32, 10, dcmpt.Id);
                    SetParameter(cmd, "@ref_compte", DbType.String, 255, dcmpt.RefCompte);
                    SetParameter(cmd, "@nom_societe", DbType.String, 255, dcmpt.NomSociete);
                    SetParameter(cmd, "@telephone", DbType.String, 100, dcmpt.Telephone);
                    SetParameter(cmd, "@addresse_societe", DbType.String, 100, dcmpt.Adresse);
                    SetParameter(cmd, "@numero_rccm", DbType.String, 100, dcmpt.NumeroRCCM);
                    SetParameter(cmd, "@email", DbType.String, 255, dcmpt.EmailProfessionnel);
                }

                cmd.ExecuteNonQuery();
            }
        }

        public void InsertUpdateClient(Client client)
        {
            using (IDbCommand cmd = Connection.Connection.Instance.Con.CreateCommand())
            {
                if (client.Id == 0)
                {
                    cmd.CommandText = "INSERT INTO `storm_sport_db`.`client` (`matricule`,`ref_carte`,`nom`, " +
                        " `postnom`,`prenom`,`adresse`,`telephone`,`type_piece`,`numero_piece`,`solde`) VALUES " +
                        " (@matricule, @ref_carte, @nom, @postnom, @prenom, @adresse, @telephone, @type_piece, " +
                        " @numero_piece, @solde); ";

                    SetParameter(cmd, "@matricule", DbType.String, 100, client.Matricule);
                    SetParameter(cmd, "@ref_carte", DbType.String, 100, client.RefCarte);
                    SetParameter(cmd, "@nom", DbType.String, 255, client.Nom);
                    SetParameter(cmd, "@postnom", DbType.String, 255, client.Postnom);
                    SetParameter(cmd, "@prenom", DbType.String, 255, client.Prenom);
                    SetParameter(cmd, "@telephone", DbType.String, 30, client.Telephone);
                    SetParameter(cmd, "@adresse", DbType.String, 255, client.Adresse);
                    SetParameter(cmd, "@type_piece", DbType.String, 255, client.TypeCarte);
                    SetParameter(cmd, "@numero_piece", DbType.String, 255, client.NumeroCarte);
                    SetParameter(cmd, "@solde", DbType.String, 35, client.Solde);
                }
                else
                {
                    cmd.CommandText = "UPDATE `storm_sport_db`.`client` SET `matricule` = @matricule, " +
                        " `ref_carte` = @ref_carte, `nom` = @nom, `postnom` = @postnom, `prenom` = @prenom, " + 
                        " `adresse` = @adresse, `telephone` = @telephone, `type_piece` = @type_piece, " +
                        " `numero_piece` = @numero_piece, `solde` = @solde WHERE `id` = @id; ";

                    SetParameter(cmd, "@id", DbType.Int32, 10, client.Id);
                    SetParameter(cmd, "@matricule", DbType.String, 100, client.Matricule);
                    SetParameter(cmd, "@ref_carte", DbType.String, 100, client.RefCarte);
                    SetParameter(cmd, "@nom", DbType.String, 255, client.Nom);
                    SetParameter(cmd, "@postnom", DbType.String, 255, client.Postnom);
                    SetParameter(cmd, "@prenom", DbType.String, 255, client.Prenom);
                    SetParameter(cmd, "@telephone", DbType.String, 30, client.Telephone);
                    SetParameter(cmd, "@adresse", DbType.String, 255, client.Adresse);
                    SetParameter(cmd, "@type_piece", DbType.String, 255, client.TypeCarte);
                    SetParameter(cmd, "@numero_piece", DbType.String, 255, client.NumeroCarte);
                    SetParameter(cmd, "@solde", DbType.String, 35, client.Solde);
                }

                cmd.ExecuteNonQuery();
            }
        }

        public User LoginRequest(string username, string password)
        {
            User user = null;

            using (IDbCommand cmd = Connection.Connection.Instance.Con.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM `storm_sport_db`.`utilisateur`	WHERE " +
                    " `utilisateur`.`username` = @username AND `utilisateur`.`password` = @password " +
                    " AND `utilisateur`.`etat` = @etat; ";

                SetParameter(cmd, "@username", DbType.String, 255, username);
                SetParameter(cmd, "@password", DbType.String, 255, password);
                SetParameter(cmd, "@etat", DbType.String, 255, "ACTIF");

                using (IDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        user = new User
                        {
                            IdSession = Convert.ToInt32(dr["id"]),
                            UsernameSession = dr["username"].ToString(),
                            PasswordSession = dr["password"].ToString()
                        };
                    }
                }
            }

            return user;
        }

        public bool UpdateUser(User user)
        {
            using (IDbCommand cmd = Connection.Connection.Instance.Con.CreateCommand())
            {
                if (user.Id == 0)
                {
                    cmd.CommandText = "UPDATE `storm_sport_db`.`utilisateur` SET `username` = @username, " +
                        " `password` = @password, `etat` = @etat WHERE `id` = @idUser; ";

                    SetParameter(cmd, "@idUser", DbType.Int32, 10, User.Instance.IdSession);
                    SetParameter(cmd, "@username", DbType.String, 255, user.Username);
                    SetParameter(cmd, "@password", DbType.String, 255, user.Password);
                    SetParameter(cmd, "@etat", DbType.String, 10, user.Etat);
                }

                return cmd.ExecuteNonQuery() != 0 ? true : false;
            }
        }

        #endregion

        #region Annexe

        public string ConvertToOwerDateTimeFormat(string field)
        {
            string date = null;

            if (field.Contains("Jan") || field.Contains("Feb") || field.Contains("Mar") ||
                field.Contains("Apr") || field.Contains("Jun") || field.Contains("Jul") ||
                field.Contains("Aug") || field.Contains("Sep") || field.Contains("Oct") ||
                field.Contains("Nov") || field.Contains("Dec"))
            {
                if (field.Contains("Jan"))
                {
                    int index = field.IndexOf("Jan");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "01");
                    date = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm:ss");
                }

                if (field.Contains("Feb"))
                {
                    int index = field.IndexOf("Feb");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "02");
                    date = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm:ss");
                }

                if (field.Contains("Mar"))
                {
                    int index = field.IndexOf("Mar");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "03");
                    date = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm:ss");
                }

                if (field.Contains("Apr"))
                {
                    int index = field.IndexOf("Apr");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "04");
                    date = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm:ss");
                }

                if (field.Contains("May"))
                {
                    int index = field.IndexOf("May");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "05");
                    date = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm:ss");
                }

                if (field.Contains("Jun"))
                {
                    int index = field.IndexOf("Jun");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "06");
                }

                if (field.Contains("Jul"))
                {
                    int index = field.IndexOf("Jul");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "07");
                    date = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm:ss");
                }

                if (field.Contains("Aug"))
                {
                    int index = field.IndexOf("Aug");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "08");
                    date = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm:ss");
                }

                if (field.Contains("Sep"))
                {
                    int index = field.IndexOf("Sep");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "09");
                    date = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm:ss");
                }

                if (field.Contains("Oct"))
                {
                    int index = field.IndexOf("Oct");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "10");
                    date = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm:ss");
                }

                if (field.Contains("Nov"))
                {
                    int index = field.IndexOf("Nov");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "11");
                    date = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm:ss");
                }

                if (field.Contains("Dec"))
                {
                    int index = field.IndexOf("Dec");
                    field = field.Remove(index, 3);
                    date = field.Insert(index, "12");
                    date = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm:ss");
                }
            }
            else
            {
                date = field;
            }

            return date;
        }

        #endregion
    }
}
