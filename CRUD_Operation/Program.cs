//watch:  https://www.youtube.com/watch?v=1UQZf4o9SNM



using System.Data.SqlClient;
// connection set korlam, DB er sathe VS er ei project er
string connectionString = @"Data Source=BS-1045\SQLEXPRESS;Initial Catalog=studentCRUD;Integrated Security=True";
SqlConnection sqlConnection = new SqlConnection(connectionString);


sqlConnection.Open();
    Console.WriteLine("Connection created");

// --------------------------------INSERT
// insert er jnno query likhlam
//int id = 5;
//string name = "SH", phone = "018", email = "BS";
//string insertQuery = "insert into Table_1(id, name, email, phone) values('" + id + "', '" + name + "', '" + email + "', '" + phone + "')";

// oi connection e ei query send korlam
//SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
//insertCommand.ExecuteNonQuery();

//Console.WriteLine("Data inserted");

//------------------------------------READ
//data read korlam from DB
//string selectQuery = "select * from Table_1";
//SqlCommand display = new SqlCommand(selectQuery, sqlConnection);
//SqlDataReader reader = display.ExecuteReader();

//while (reader.Read())
//{
//    Console.WriteLine("user -" + reader.GetValue(0).ToString() + " " + reader.GetValue(1).ToString()
//        + " " + reader.GetValue(2).ToString());
//}
//reader.Close();

//-------------------------------------------UPDATE
//string phone = "019";
//string update = "update Table_1 set phone ="+phone+"";
//SqlCommand updateQuery = new SqlCommand(update, sqlConnection);

//updateQuery.ExecuteNonQuery();


//--------------------------------------------DELETE
string Name = "a";
    string delete = "delete from Table_1 where name = '"+Name+"'";
    SqlCommand deleteQuery = new SqlCommand(delete, sqlConnection);

    deleteQuery.ExecuteNonQuery();

sqlConnection.Close();

Console.ReadKey();



