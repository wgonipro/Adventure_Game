﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterBrain : ScriptableObject
{
    public virtual void Initialize(CharacterThinker character) { }
    public abstract void PassiveThink(CharacterThinker character);
    public abstract bool BattleThink(CharacterThinker character);
}
