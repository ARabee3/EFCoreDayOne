using Demo.Contexts;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region EFCore?
            // what is efcore? => ORM Tool for .Net 
            // ORM (Object Relational Mapper) it is the way to interact between Application and database
            // App ==== ORM ==== Database

            // Why EF Core? :
            // 1- Mapping (Code-First) , (DB-First)
            // (Code-First) : By writing CSharp code the efcore will do the mapping and generate table per each class
            // (Database-First) : Build the database first, will generate class per each table

            // 2- L2E (Linq to Entity) using efcore makes you write linq query to the database

            // Ways to generate Schema:
            // Code-First: 1- (TPC) (Table Per Class) : Default Behaviour
            // 2- (TPH) (Table Per Hierarchy) ==> Makes one table and uses Discriminator to specify the type
            // 3- (TPCC) (Table Per Concrete Class)

            // ORM Tools => ADO.NET, Dapper, EF Core
            // the difference between the 3 tools 
            // https://www.csharp.com/article/ado-net-vs-entity-framework-understanding-the-differences/


            #endregion

            #region Mapping By Convention, Data Annotation
            // EF Core Support 4 ways for mapping classes in database [Table, View , Function]
            // 1. By Convention (Default Behaviour) => Classes will be mapped as table, each property will be a column
            // 2. Data Annotation [Set Of Attributes Used for data validation]
            
            #endregion

            AppDbContext context = new();

            #region Migration
            // it is a way to apply the changes you would like to make to the database
            // 3 Ways
            // Code, GUI , Command Line [Best]
            // Add-Migration "Migration Name" 
            // snapshot is the last shape of database
            // Update-Database "Name of the migration before the recent one" ==> Reverts the recent one
            // not prefereed to edit the migrations file manually

            #endregion

            #region FluentAPI

            #endregion

        }
    }
}
