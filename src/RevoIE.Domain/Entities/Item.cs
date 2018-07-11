using RevoIE.Domain.Enums;
using System;

namespace RevoIE.Domain.Entities
{
    public class Item
    {
        public UInt16 Id { get; set; }
	    public string Name { get; set; }
		public UInt16 GroundSpeed { get; set; }
		public ItemType ItemType { get; set; }
        
		public UInt16 AlwaysOnTopOrder { get; set; }
		public bool AlwaysOnTop { get; set; }
		public bool AllowDistRead { get; set; }

		public bool HasUseWith { get; set; }
		public bool HasHeight { get; set; }
        
		public bool IsAnimation { get; set; }
        public bool IsStackable { get; set; }
		public bool IsReadable { get; set; }
		public bool IsMoveable { get; set; }
		public bool IsPickupable { get; set; }
		public bool IsHangable { get; set; }
		public bool IsHorizontal { get; set; }
		public bool IsVertical { get; set; }
		public bool IsRotatable { get; set; }

		public UInt16 MaxReadChars { get; set; }
		public UInt16 MaxReadWriteChars { get; set; }
		public UInt16 MinimapColor { get; set; }
		public UInt16 LightLevel { get; set; }
		public UInt16 LightColor { get; set; }
		
		public bool BlockObject { get; set; }
		public bool BlockProjectile { get; set; }
		public bool BlockPathFind { get; set; }
		public bool LookThrough { get; set; }
	    public bool WalkStack { get; set; }

	    public UInt16 WareId { get; set; }
        
		//used to find sprites during updates
		protected byte[] _spriteHash = null;
		public virtual byte[] SpriteHash
		{
			get {return _spriteHash;}
			set {_spriteHash = value;}
		}
    }
}
