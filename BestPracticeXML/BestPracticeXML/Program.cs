using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BestPracticeXML
{
    class Program
    {
        static void Main(string[] args)
        {
            //Needed XML

            //<ReceiptDetailQuantityChanged>
            //<ReceiptDetailId>129112770</ReceiptDetailId>
            //<Quantity>1</Quantity>
            //<QuantityChange>1</QuantityChange>
            //<OrderDetailSubId>120270390</OrderDetailSubId>
            //<Portion>1</Portion>
            //<UserId>1192</UserId>
            //<CompName>COMP020</CompName>
            //<AppName>Customers</AppName>
            //</ReceiptDetailQuantityChanged>

            long receiptDetailId = 129112770;
            int quantity = 1;
            int quantityChange = 1;
            long orderDetailSubId = 120270390;
            int portion = 1;
            long userId = 1192;
            string compName = System.Environment.MachineName;
            string appName = "StockManage";
            string messageType = "ReceiptDetailQuantityChanged";

          






        }
    }
}
