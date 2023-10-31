using Design_Patterns.Creational.Factory.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Creational.Factory
{
    class SQLServer : ISQLConneection
    {
        public string GetConnection()
        {
            return "PostgreSQL Connnection string";
        }
    }
}
