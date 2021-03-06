using KragmortaApp.Enums;

namespace KragmortaApp.FileDatas
{
    public class FieldCellFileData
    {
        /// <summary>
        /// Field X coordinate
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Field Y coordinate
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// The type of current cell
        /// </summary>
        public CellType Type { get; set; }

        public CellForm Form { get; set; }

        public Corner Corner { get; set; }

        public bool Visible { get; set; }

        public bool IsPortal { get; set; }
    }
}