using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ItemManager.Models
{
    string name;
    int weight;
    bool equip;
    SqlConnection con= new SqlConnection("Data Source=.;Initial Catalog=Sample;Integrated Security=true;");  
    SqlCommand cmd;  
    SqlDataAdapter adapt;  
    //ID variable used in Updating and Deleting Record  
    int ID = 0; 

    if (txt_Name.Text != "" && txt_State.Text != "") {  
    cmd = new SqlCommand("insert into tbl_Record(Name,State) values(@name,@state)", con);  
    con.Open();  
    cmd.Parameters.AddWithValue("@name", txt_Name.Text);  
    cmd.Parameters.AddWithValue("@state", txt_State.Text);  
    cmd.ExecuteNonQuery();  
    con.Close();  
    MessageBox.Show("Record Inserted Successfully");  
    DisplayData();  
    ClearData();  
    } else {  
    MessageBox.Show("Please Provide Details!");  
    }  

    class Item
    {
        static void Main(string[] args)
        {
        }
    }
}
//Id: int
//Name: string
//Weight: int
//Rating: float
//Wearable: Bool