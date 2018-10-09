using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Book
    {
        private List<string> histories;

        public Book() {
            histories = new List<string>();
        }

        public void addHistory(string date, string history)
        {
            histories.Add(date+": "+history);
        }
        public List<string> getBook()
        {
            return this.histories;
        }
    }
}
