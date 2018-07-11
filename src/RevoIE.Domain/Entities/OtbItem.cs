using System;

namespace RevoIE.Domain.Entities
{
    public class OtbItem : Item
    {
		public UInt16 spriteId { get; set; }
		public UInt16 prevSpriteId { get; set; }

		//Used during an update to indicate if this item has been updated
		public bool SpriteAssigned { get; set; }

		//An custom created item id
		public bool IsCustomCreated { get; set; }

        public OtbItem()
        {
            SpriteAssigned = false;
            IsCustomCreated = false;
        }
    }
}
