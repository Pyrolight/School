using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Tier
{
    class BusinessLayer

    {
        private List<String> title;
        public List<String> getTitle() {
            title = new List<String>();
            DAO getTitle = new DAO();
            title = getTitle.titleDAO();
            return this.title;
        }
    }
}
