﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPtDLab1
{
	static class DESProvider
	{

		private const int bitsInByte = 8;

		const int amountOfBits = 64;

		const int ammountOfBytes = 8;


		private static readonly int[] startShuffleMatrix =
		{
			58, 50, 42, 34, 26, 18, 10, 02,
			60, 52, 44, 36, 28, 20, 12, 04,
			62, 54, 46, 38, 30, 22, 14, 06,
			64, 56, 48, 40, 32, 24, 16, 08,
			57, 49, 41, 33, 25, 17, 09, 01,
			59, 51, 43, 35, 27, 19, 11, 03,
			61, 53, 45, 37, 29, 21, 13, 05,
			63, 55, 47, 39, 31, 23, 15, 07
		};

		private static readonly int[] finishShuffleMatrix =
		{
			40, 08, 48, 16, 56, 24, 64, 32,
			39, 07, 47, 15, 55, 23, 63, 31,
			38, 06, 46, 14, 54, 22, 62, 30,
			37, 05, 45, 13, 53, 21, 61, 29,
			36, 04, 44, 12, 52, 20, 60, 28,
			35, 03, 43, 11, 51, 19, 59, 27,
			34, 02, 42, 10, 50, 18, 58, 26,
			33, 01, 41, 09, 49, 17, 57, 25
		};

		public static byte[] Encrypt(byte[] message, long key)
		{
			byte[] extendedMessage = ExtendTo64Blocks(message);
			byte[] cryptogram = new byte[extendedMessage.Length];
			for (int i = 0; i < extendedMessage.Length; i += 8)
			{
				long block = BitConverter.ToInt64(extendedMessage, i);
				long shuffledBlock = Shuffle(block, startShuffleMatrix);
				int left = (int)(shuffledBlock >> 32);
				int right = (int)shuffledBlock;
				FeistelNetwork(ref left, ref right, key);
				long encryptedShuffledBlock = (((long)left) << 32) | (long)right;
				long encryptedBlock = Shuffle(encryptedShuffledBlock, finishShuffleMatrix);
				byte[] byteBlock = BitConverter.GetBytes(encryptedBlock);
				Array.Copy(byteBlock, 0, cryptogram, i, 8);

			}

			return cryptogram;
		}

		private static byte[] ExtendTo64Blocks(byte[] message)
		{
			int newLength = message.Length + 8 - (message.Length % ammountOfBytes);
			byte[] extendedMessage = new byte[newLength];
			Array.Copy(message, extendedMessage, message.Length);
			return extendedMessage;
		}

		private static long Shuffle(long block, int[] shuffleMatrix)
		{
			long result = 0;
			for (int i = 0; i < 64; i++)
			{
				long bit = (block >> shuffleMatrix[i] - 1) & 1;
				result |= bit << i;
			}

			return result;
		}

		private static void FeistelNetwork(ref int left, ref int right, long key)
		{

		}

	}
}
