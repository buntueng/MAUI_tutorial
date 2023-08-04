using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionview_example.views
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public string PlayerImage { get; set; }
        public string Country { get; set; }

        ObservableCollection<Player> players = new ObservableCollection<Player>();
        public ObservableCollection<Player> Players { get { return players; } }



    }



}
