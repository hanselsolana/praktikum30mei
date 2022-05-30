using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace praktikum30mei
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtTypePemain = new DataTable();
        DataTable dtPremier_league = new DataTable();
        DataTable dtSkorPemain = new DataTable();
        int PosisiSekarang;
       

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlQuery = "select team_name as Team, concat(manager_name,' (', city,')') as Manager, concat(home_stadium,' ', city,' (', capacity,')') as stadium from team, manager, player;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTypePemain);
            sqlQuery = "select concat(p.player_name,' ',sum(if(d.`type` = 'GO' or d.`type` ='GP',1, 0)),'(',sum(if(d.`type` ='GP',1, 0)),')')  as 'Top Score' from player p, dmatch d where  p.player_id=d.player_id group by p.player_id order by 1";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtSkorPemain);
            IsiDataPemain(0);
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        public void IsiDataPemain(int Posisi)
        {
            lbl_teamname.Text = dtTypePemain.Rows[Posisi][0].ToString();
            lbl_manager.Text = dtTypePemain.Rows[Posisi][1].ToString();
            lbl_stadium.Text = dtTypePemain.Rows[Posisi][2].ToString();
            //lbl_topscore.Text = dtSkorPemain.Rows[Posisi][0].ToString();
            
           
        }


        private void btn_leftt_Click(object sender, EventArgs e)
        {
            IsiDataPemain(0);
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang > 0)
            {
                PosisiSekarang--;
                IsiDataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Pertama");
            }
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang < dtTypePemain.Rows.Count - 1)
            {
                PosisiSekarang++;
                IsiDataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Terakhir");
            }
        }

        private void btn_rightt_Click(object sender, EventArgs e)
        {
            IsiDataPemain(dtTypePemain.Rows.Count - 1);
        }

        private void lbl_stadium_Click(object sender, EventArgs e)
        {
           
        }
    }
}
