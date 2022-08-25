using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuizUI : MonoBehaviour
{
    [SerializeField] private Text m_question = null;
    [SerializeField] private List<OptionButton> m_buttonsList = null;


    public void Constructc(Question q , Action<OptionButton> Callback)
    {
        m_question.text = q.text;

        for(int n = 0; n < m_buttonsList.Count; n++)
        {
            m_buttonsList[n].construct(q.options[n], Callback);
        }

    }

}
