using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "QuestionsData", menuName = "QuestionsData", order = 1)]
public class UIManager : ScriptableObject
{
    public string categoryName;
    public List<Question> questions;
}
