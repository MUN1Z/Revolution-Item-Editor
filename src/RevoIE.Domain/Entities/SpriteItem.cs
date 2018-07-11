using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;

namespace RevoIE.Domain.Entities
{
    public class SpriteItem : Item
	{
		public byte Width { get; set; }
		public byte Height { get; set; }
		public byte Frames { get; set; }
		public byte XDiv { get; set; }
		public byte YDiv { get; set; }
		public byte ZDiv { get; set; }
		public byte AnimationLength { get; set; }
		public UInt32 NumSprites { get; set; }

		public List<Sprite> SpriteList { get; set; }

        public SpriteItem()
        {
            SpriteList = new List<Sprite>();
        }

		public override byte[] SpriteHash
		{
			get
			{
				if (_spriteHash == null)
				{
					var md5 = MD5.Create();

					var spriteSize = Width * Height * AnimationLength;
					var spriteBase = 0;

					var stream = new MemoryStream();

					for (var frame = 0; frame < Frames; frame++)
					{
						for (var cy = 0; cy < Height; cy++)
						{
							for (var cx = 0; cx < Width; cx++)
							{
								var frameIndex = spriteBase + cx + cy * Width + frame * Width * Height;
								var sprite = SpriteList[frameIndex];
								if (sprite != null)
								{
									stream.Write(sprite.GetRGBAData(), 0, 32 * 32 * 4);
								}
							}
						}
					}

					stream.Position = 0;
					_spriteHash = md5.ComputeHash(stream);
				}

				return _spriteHash;
			}

			set
			{
				_spriteHash = value;
			}
		}
        
        public double[,] SpriteSignature { get; set; }
        public byte[] GetRGBData() => SpriteList[0].GetRGBData();
		public byte[] GetRGBData(int frameIndex) => SpriteList[frameIndex].GetRGBData();
		public byte[] GetRGBAData() => SpriteList[0].GetRGBAData();
		public byte[] GetRGBAData(int frameIndex) => SpriteList[frameIndex].GetRGBAData();
	}
}
