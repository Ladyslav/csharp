namespace Game_Zombies
{
    public class item : ICloneable
    {
        public string name;
        public int Id;
        public bool isStack;
        public int count;

        public item(string name, int Id, bool isStack,int count = 1)
        {
            this.name = name;
            this.Id = Id;
            this.isStack = isStack;
            this.count = count;
        }

        public object Clone()
        {
            return this;
        }
    }




}