﻿using System;
using UnityEngine;

namespace Assets._Scripts_._Character_Types_
{
	class Mage : MonoBehaviour, CharacterTypeInterface
	{
		int att;
		int heal;
		int leftLife;
		int fullLife;

		public Mage(int lvl)
		{
			CalculateStats(lvl);
		}

		public int LeftLife
		{
			get
			{
				return leftLife;
			}
		}

		public int FullLife
		{
			get
			{
				return fullLife;
			}
		}

		public int ReachA
		{
			get
			{
				return 5;
			}
		}

		public int ReachW
		{
			get
			{
				return 0;
			}
		}

		public int Attack()
		{
			return att;
		}

		public void CalculateStats(int lvl) //not balanced
		{
			fullLife = 50 + 10 * lvl;
			att = 5 + 5 * lvl;
			heal = fullLife / 15;
			leftLife = fullLife;
		}

		public void GetHurt(int dmg)
		{
			leftLife -= dmg;
		}

		public void Heal()
		{
			if (leftLife + heal <= fullLife)
				leftLife += heal;
			else
				leftLife = fullLife;
		}

		public void Walk()
		{
			//trigger animation?
			//for eatch tile walked
		}
	}
}
