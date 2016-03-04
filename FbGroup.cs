using System;

namespace FacebookSeller
{
    [Serializable]
    public class FbGroup
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsChecked { get; set; }

        public FbGroup(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
