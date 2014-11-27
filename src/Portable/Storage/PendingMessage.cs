﻿using Hermes.Packets;

namespace Hermes.Storage
{
	public class PendingMessage
	{
		public QualityOfService QualityOfService { get; set; }

		public bool Duplicated { get; set; }

		public bool Retain { get; set; }

		public string Topic { get; set; }

		public ushort? PacketId { get; set; }

		public byte[] Payload { get; set; }
	}
}
