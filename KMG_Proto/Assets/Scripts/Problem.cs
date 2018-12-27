using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem : MonoBehaviour {

    public GameObject ProblemText;
    public GameObject[] AnwserText = new GameObject[3];
    public GameObject[] Colliders = new GameObject[3];

    private prob[] probs = new prob[5];

    private int Answer;

    struct prob {
        public string pro;
        public string ans1;
        public string ans2;
        public string ans3;
        public int a;
        public prob(string pro, string ans1, string ans2, string ans3, int a) {
            this.pro = pro;
            this.ans1 = ans1;
            this.ans2 = ans2;
            this.ans3 = ans3;
            this.a = a;
        }
    };

    void Awake() {
        probs[0] = new prob("백*천", "만", "십만", "백만", 1);
        probs[1] = new prob("천*백만", "억", "십억", "백억", 1);
        probs[2] = new prob("십*백", "십", "백", "천", 2);
        probs[3] = new prob("백억*십", "천억", "조", "십조", 0);
        probs[4] = new prob("만*만", "만", "백만", "억", 2);
        SetProblem(probs[Random.Range(0, 5)]);
    }

    void SetProblem(prob p) {
        ProblemText.GetComponent<TextMesh>().text = p.pro;
        AnwserText[0].GetComponent<TextMesh>().text = p.ans1;
        AnwserText[1].GetComponent<TextMesh>().text = p.ans2;
        AnwserText[2].GetComponent<TextMesh>().text = p.ans3;
        Answer = p.a;
        Colliders[p.a].tag = "answer";
    }
}
