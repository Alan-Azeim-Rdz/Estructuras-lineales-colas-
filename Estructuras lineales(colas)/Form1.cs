namespace Estructuras_lineales_colas_
{
    public partial class Form1 : Form
    {
        private Queue queue;
        private int currentTurn;
        public Form1()
        {
            InitializeComponent();
            queue = new Queue();
            currentTurn = 1;
        }




        private void BtnAddTurn_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtDishName.Text) && double.TryParse(TxtDishPrice.Text, out double price))
            {
                // Crear el platillo
                Dish dish = new Dish(TxtDishName.Text, price);

                // Crear un nodo con el turno actual y el platillo
                Node newNode = new Node(currentTurn, dish);

                // Agregar el nodo a la cola
                queue.Enqueue(newNode);

                // Crear el ítem para mostrar en el ListView
                ListViewItem item = new ListViewItem(newNode.ToString());
                LstBoxQueue.Items.Add(dish.ToString());

                // Incrementar el número del turno
                currentTurn++;

                // Limpiar los campos de entrada
                TxtDishName.Clear();
                TxtDishPrice.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un nombre y un precio válidos para el platillo.");
            }
        }

        private void BtnServeTurn_Click(object sender, EventArgs e)
        {
            if (!queue.IsEmpty())
            {
                Node servedNode = queue.Dequeue();

                ListViewItem item = new ListViewItem(servedNode.Turn.ToString());
                item.SubItems.Add(servedNode.Dish.ToString());
                LstBoxServedTurns.Items.Add(servedNode.ToString());

                if (LstBoxQueue.Items.Count > 0)
                    LstBoxQueue.Items.RemoveAt(0);
            }
            else
            {
                MessageBox.Show("No hay turnos en la cola.");
            }
        }
    }
}

