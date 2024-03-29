﻿using UnityEngine;

namespace DotPlay
{
	/// <summary>
	/// Types that currencies can modify
	/// </summary>
	public enum CurrencyModifyType
	{
		Add,
		Subtract,
		Set
	}

	/// <summary>
	/// For game currencies encryption & to
	/// prevent modifying game
	/// </summary>
	public class CurrencyAgent
	{
		/// <summary>
		/// The Encrypted string
		/// Contains letters, not numbers
		/// </summary>
		private static string _encryptedToPlayerPrefs = string.Empty;

		/// <summary>
		/// The Decrypted string
		/// Contains numbers
		/// </summary>
		private static string _encryptedFromPlayerPrefs = string.Empty;

		/// <summary>
		/// Changes the Id's value, encrypts it & stores it
		/// </summary>
		/// <param name="id"></param>
		/// <param name="currencyChangeType"></param>
		/// <param name="amount"></param>
		public static void Encrypt (byte id, CurrencyModifyType currencyChangeType, int amount)
		{

			if (currencyChangeType == CurrencyModifyType.Set)
			{
				int[] nums = MathAgent.Split (amount);

				for (int i = 0; i < nums.Length; i++)
				{
					switch (nums[i])
					{
						case 0:
						_encryptedToPlayerPrefs += "a";
						break;

						case 1:
						_encryptedToPlayerPrefs += "b";
						break;

						case 2:
						_encryptedToPlayerPrefs += "c";
						break;

						case 3:
						_encryptedToPlayerPrefs += "d";
						break;

						case 4:
						_encryptedToPlayerPrefs += "e";
						break;

						case 5:
						_encryptedToPlayerPrefs += "f";
						break;

						case 6:
						_encryptedToPlayerPrefs += "g";
						break;

						case 7:
						_encryptedToPlayerPrefs += "h";
						break;

						case 8:
						_encryptedToPlayerPrefs += "i";
						break;

						case 9:
						_encryptedToPlayerPrefs += "j";
						break;
					}
				}
			}
			else if (currencyChangeType == CurrencyModifyType.Add)
			{
				int i = Decrypt(id);
				int iToPrefs = i + amount;

				Encrypt (id, CurrencyModifyType.Set, iToPrefs);
			}
			else if (currencyChangeType == CurrencyModifyType.Subtract)
			{
				int i = Decrypt(id);
				int iToPrefs = i - amount;

				Encrypt (id, CurrencyModifyType.Set, iToPrefs);
			}

			PlayerPrefs.SetString ($"{id}.currency", _encryptedToPlayerPrefs);
		}

		/// <summary>
		/// Decrypts & returns the Id's value
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public static int Decrypt (byte id)
		{
			string s = PlayerPrefs.GetString($"{id}.currency");
			char[] sSplited = s.ToCharArray();

			for (int i = 0; i < sSplited.Length; i++)
			{
				switch (sSplited[i])
				{
					case 'a':
					_encryptedFromPlayerPrefs += "0";
					break;

					case 'b':
					_encryptedFromPlayerPrefs += "1";
					break;

					case 'c':
					_encryptedFromPlayerPrefs += "2";
					break;

					case 'd':
					_encryptedFromPlayerPrefs += "3";
					break;

					case 'e':
					_encryptedFromPlayerPrefs += "4";
					break;

					case 'f':
					_encryptedFromPlayerPrefs += "5";
					break;

					case 'g':
					_encryptedFromPlayerPrefs += "6";
					break;

					case 'h':
					_encryptedFromPlayerPrefs += "7";
					break;

					case 'i':
					_encryptedFromPlayerPrefs += "8";
					break;

					case 'j':
					_encryptedFromPlayerPrefs += "9";
					break;
				}
			}

			if (string.IsNullOrWhiteSpace(_encryptedFromPlayerPrefs))
			{
				return 0;
			}

			return int.Parse (_encryptedFromPlayerPrefs);
			//TODO: FIX ERRORS
		}
	}
}