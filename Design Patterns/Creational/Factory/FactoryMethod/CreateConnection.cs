using Design_Patterns.Creational.Factory.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Creational.Factory.FactoryMethod
{
    class CreateConnection
    {
        public static ISQLConneection getConnection(string connectionType)
        {
            switch (connectionType)
            {
                case "SQLServer":
                    return new SQLServer();
                case "PostgreSQL":
                    return new PostgreSQL();
                default:
                    return null;
            }

        }
    }
}
