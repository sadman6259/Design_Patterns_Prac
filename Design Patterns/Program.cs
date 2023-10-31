using Design_Patterns.Creational.Factory.FactoryMethod;
using Design_Patterns.Creational.Factory.Interface;
using Design_Patterns.Creational.Singleton;
using Design_Patterns.Structural.Facade.FacadeMethod;
using System;
using System.Text;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Factory

            ISQLConneection ConneectionSQLserver = CreateConnection.getConnection("SQLServer");
            ISQLConneection ConneectionPostgreSQL = CreateConnection.getConnection("PostgreSQL");


            Console.WriteLine(ConneectionSQLserver.GetConnection());
            Console.WriteLine(ConneectionPostgreSQL.GetConnection());

            // Singleton
            Logger logger = Logger.GetLoggerInstance;
            Console.WriteLine(logger.getMessage("log text"));

            // Facade
            OrderPlacementFacade orderPlacementFacade = new OrderPlacementFacade();
            StringBuilder output = orderPlacementFacade.OrderPlacement();
            Console.WriteLine(output);

        }
    }
}
