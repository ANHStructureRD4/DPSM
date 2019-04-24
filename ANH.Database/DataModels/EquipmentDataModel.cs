namespace ANH.Database
{
    /// <summary>
    /// A data model for Base list item
    /// </summary>
    public class EquipmentDataModel
    {
        /// <summary>
        /// Auto increase id
        /// </summary>
        public int EquipID { get; set; }
        
        /// <summary>
        /// The display base name
        /// </summary>
        public string EquipName { get; set; }

        /// <summary>
        /// The base count 
        /// </summary>
        public int cnt { get; set; }

        /// <summary>
        /// True if this item is currently selected
        /// </summary>
        public bool IsSelected { get; set; }

        /// <summary>
        /// The icon source of local storage
        /// </summary>
        public string IconSource { get; set; }
    }
}
