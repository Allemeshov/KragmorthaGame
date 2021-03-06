using KragmortaApp.FileDatas;

namespace KragmortaApp.Entities
{
    public class MagicBook
    {
        public int Power { get; set; }

        public MagicBook(int power)
        {
            Power = power;
        }
        public MagicBook(MagicBookFileData fileData)
        {
            Power = fileData.Power;
        }

        public MagicBookFileData ToFileData()
        {
            return new MagicBookFileData()
            {
                Power = Power
            };
        }
    }
}