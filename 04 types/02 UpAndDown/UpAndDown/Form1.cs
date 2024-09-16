
namespace UpAndDown
{
    public partial class Form1 : Form
    {
        private const int size = 16;
        Square player = new Square();
        Level level = new Level(
            [
                "#........#",
                "#........#",
                "#...P....#",
                "#........#",
                "#........#",
                "#........#",
                "#........#",
                "#........#",
                "#........#",
                "#........#",
                "#........#",
                "#........#",
                "#........#",
                "#........#",
                "#........#",
                "#........#",
                "#........#",
            ]
        , size
            );

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;

            player.x = size*3;
            player.y = size;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.Clear(Color.Black);

            foreach (Tile[] row in level.tiles)
            {
                foreach (Tile tile in row)
                {
                    e.Graphics.FillRectangle(tile.color, tile.x, tile.y, size, size);
                }


            }
            e.Graphics.FillRectangle(player.color, player.x, player.y, size, size);

        }

        public void DoLogic(float frametime)
        {
			//2) Zoek uit waarom de speler weer naar boven gaat, zet de reden hieronder achter de  //> neer
			//>
            /* De Byte datatype is een ondertekend geheel getal dat waarden tussen 0 en 255 kan opslaan
             * Als de waarde groter dan 255 is,
             * wordt de waarde gecorrigeerd naar 0. Met een int gebeurd dit niet
             */
            player.y += 5;
        }
    }
}
