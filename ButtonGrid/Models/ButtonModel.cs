using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ButtonGrid.Controllers
{
    public class ButtonModel
    {
        public int Id { get; set; }
        public int State { get; set; }

        public ButtonModel(int id, int state)
        {
            this.Id = id;
            this.State = state;
        }
    }
}
