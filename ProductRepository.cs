using System.Data;
using dpu.Entities;
using Microsoft.Data.SqlClient;

namespace dpu.Repositories;

public class ProductRepository : IProductRepository
{
    private DatabaseContext _databaseContext;

    public ProductRepository(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
    }

    public Product? GetProduct(int id)
    {
        return _databaseContext.Products.Where(w => w.Id == id).FirstOrDefault();
    }

    public Product? GetProductById(int id)
    {
        using (SqlConnection conn = new SqlConnection("Server=db.ciofuwpvxhep.ap-southeast-1.rds.amazonaws.com,1433;Initial Catalog=surasak;User ID=sa;Password=Aa123456"))
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("GetProductById", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", id));

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    var product = new Product()
                    {
                        Id = rdr.GetInt32("id"),
                        Title = rdr.GetString("title"),
                        IsActive = rdr.GetBoolean("isActive")
                    };

                    conn.Close();

                    return product;
                }
            }

            return null;
        }
    }

    public IQueryable<Product> GetProducts()
    {
        return _databaseContext.Products;
    }
}
