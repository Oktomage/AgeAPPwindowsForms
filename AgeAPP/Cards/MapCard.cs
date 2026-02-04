using static AgeAPP.Classes.Main_classes;
using static AgeAPP.Classes.MainFunctions;
using static AgeAPP.Styles.CSS;

namespace AgeAPP.Cards
{
    public partial class MapCard : UserControl
    {
        public MapCard()
        {
            InitializeComponent();
            HoverStyles.CardHover(this);
        }

        public void Bind(Map map)
        {
            // Nome
            MapNameLabel.Text = map.Name;

            // Tipo
            MapStyleLabel.Text = $"Estilo: {GetMapTypeName(map.Type)}";

            // Partidas
            MapMatchesLabel.Text = $"Total de partidas: {map.Matches}";

            // Imagem
            MapPictureBox.BackgroundImage = MapImageDictionary.Get(map.Name);
        }
    }
}
