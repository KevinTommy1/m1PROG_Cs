

namespace MenuDraw
{
    public partial class Form1 : Form
    {
        Equipment[] inventory;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;

            inventory = new Equipment[]
            {
                new Equipment("The minotaur",EquipmentType.Axe),
                new Equipment("The Grandfather",EquipmentType.Sword),
                new Equipment("corpsemourn",EquipmentType.ChestArmor),
                new Equipment("immortal kings pillar",EquipmentType.LegArmor)
            };

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.Clear(Color.Black);
            //1) maak hier een for loop, die over inventory loopt
            for (int i = 0; i < inventory.Length; i++)
            {

                //2) haal hier het item op [i] op, zie MenuDraw als je het even niet weet
                Equipment item = inventory[i]; ;
                if (item.type == EquipmentType.Sword)//3) test hier of item.type GELIJK is aan EquipmentType.Sword
                {
                    e.Graphics.DrawImage(item.image, 0, 0);
                }

                if (item.type == EquipmentType.Axe)
                {
                    e.Graphics.DrawImage(item.image , 300, 0);
                }
                
            }
        }

        internal void DoLogic(float frametime)
        {
            //gebruiken we nu even niet
        }
    }
}
