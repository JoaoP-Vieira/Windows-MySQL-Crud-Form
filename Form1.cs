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

namespace WindowsFormsApp1
{
  public partial class Form1 : Form
  {
    MySqlConnection connection;
    MySqlCommand command;
    MySqlDataAdapter adapter;
    MySqlDataReader reader;
    string strSQL;

    public Form1()
    {
      InitializeComponent();
    }

    private void connectDb()
    {
      if (connection == null) {
        // Add your connect credentials here
        connection = new MySqlConnection("Server=localhost;Database=database;Uid=user;Pwd=password;");
        connection.Open();
      }
    }
    private void desconnectDb()
    {
      if (connection != null)
      {
        connection.Close();
        connection = null;
      }
    }

    // Add btn
    private void button1_Click(object sender, EventArgs e)
    {
      if (connection != null)
      {
        try
        {
          strSQL = "INSERT INTO products (NAME, TYPE) VALUES (@NAME, @TYPE)";

          command = new MySqlCommand(strSQL, connection);
          command.Parameters.AddWithValue("@NAME", labelName.Text);
          command.Parameters.AddWithValue("@TYPE", labelType.Text);

          command.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message);
        }
        finally
        {
          command = null;
        }
      }
      else {
        MessageBox.Show("Please connect first");
      }
    }

    // Update btn
    private void button2_Click(object sender, EventArgs e)
    {
      if (connection != null)
      {
        try
        {
          connectDb();

          strSQL = "UPDATE products SET NAME = @NAME, TYPE = @TYPE WHERE ID = @ID";

          command = new MySqlCommand(strSQL, connection);
          command.Parameters.AddWithValue("@ID", labelId.Text);
          command.Parameters.AddWithValue("@NAME", labelName.Text);
          command.Parameters.AddWithValue("@TYPE", labelType.Text);

          command.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message);
        }
        finally
        {
          desconnectDb();
          command = null;
        }
      }
      else {
        MessageBox.Show("Please connect first");
      }
    }

    // Delete btn
    private void button3_Click(object sender, EventArgs e)
    {
      if (connection != null) {
      try
      {
        connectDb();

        strSQL = "DELETE FROM products WHERE ID = @ID";

        command = new MySqlCommand(strSQL, connection);
        command.Parameters.AddWithValue("@ID", labelId.Text);

        command.ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
      finally
      {
        desconnectDb();
        command = null;
      }}
    }

    // Search btn
    private void button4_Click(object sender, EventArgs e)
    {
      try
      {
        connectDb();

        strSQL = "SELECT * FROM products WHERE ID = @ID";

        command = new MySqlCommand(strSQL, connection);
        command.Parameters.AddWithValue("@ID", labelId.Text);

        connection.Open();
        reader = command.ExecuteReader();

        while (reader.Read()) {
          labelName.Text = Convert.ToString(reader["name"]);
          labelType.Text = Convert.ToString(reader["type"]);
        }
          
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
      finally
      {
        desconnectDb();
        command = null;
      }
    }

    // Show btn
    private void button5_Click(object sender, EventArgs e)
    {
      try
      {
        connectDb();

        strSQL = "SELECT * FROM products";

        adapter = new MySqlDataAdapter(strSQL, connection);

        DataTable dt = new DataTable();

        adapter.Fill(dt);

        dataGrid.DataSource = dt;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
      finally
      {
        desconnectDb();
        command = null;
      }
    }
  }
}
