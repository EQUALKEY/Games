﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DB : MonoBehaviour
{

    public struct stageSRC
    {
        public int size;
        public int[,] init;
        public int[,] answer;
        public int[] Oper;
        public int[] Num;
        public int remain;

        public stageSRC(int size, int[,] init, int[,] answer, int[] Oper, int[] Num, int remain)
        {
            this.size = size;
            this.init = init;
            this.answer = answer;
            this.Oper = Oper;
            this.Num = Num;
            this.remain = remain;
        }
    }
    public stageSRC[,] stageDB = new stageSRC[5, 101];


    // Use this for initialization
    public void loadDB()
    {
        stageDB[1, 1] = new stageSRC(4,
new int[,] {
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0}
},
new int[,] {
{0,0,0,0},
{0,1,0,0},
{0,2,0,0},
{0,0,0,0}
},
new int[] { 0, 1, 0, 0, 0, 0, 0 },
new int[] { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
1
)

;
        stageDB[1, 2] = new stageSRC(4,
new int[,] {
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0}
},
new int[,] {
{0,0,0,0},
{0,1,0,0},
{0,3,3,0},
{0,0,0,0}
},
new int[] { 0, 1, 0, 0, 0, 0, 0 },
new int[] { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
1
)

;

        stageDB[1, 3] = new stageSRC(4,
new int[,] {
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0}
},
new int[,] {
{0,0,0,0},
{0,1,4,0},
{0,4,4,0},
{0,0,0,0}
},
new int[] { 0, 2, 0, 0, 0, 0, 0 },
new int[] { 0, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
2
)

;

        stageDB[1, 4] = new stageSRC(4,
new int[,] {
{0,0,0,0},
{0,1,0,0},
{0,1,0,0},
{0,0,0,0}
},
new int[,] {
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0}
},
new int[] { 0, 0, 1, 0, 0, 0, 0 },
new int[] { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
1
)

;
        stageDB[1, 5] = new stageSRC(4,
new int[,] {
{0,0,0,0},
{0,1,0,0},
{0,5,5,0},
{0,0,0,0}
},
new int[,] {
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0}
},
new int[] { 0, 0, 1, 0, 0, 0, 0 },
new int[] { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
1
)

;
        stageDB[1, 6] = new stageSRC(4,
new int[,] {
{0,0,0,0},
{0,1,3,0},
{0,3,3,0},
{0,0,0,0}
},
new int[,] {
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0}
},
new int[] { 0, 1, 2, 0, 0, 0, 0 },
new int[] { 0, 2, 1, 0, 0, 0, 0, 0, 0, 0 },
3
)

;
        stageDB[1, 7] = new stageSRC(4,
new int[,] {
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0}
},
new int[,] {
{0,0,0,0},
{0,3,3,0},
{0,3,3,0},
{0,0,0,0}
},
new int[] { 0, 1, 1, 0, 0, 0, 0 },
new int[] { 0, 1, 0, 0, 1, 0, 0, 0, 0, 0 },
2
)

;
        stageDB[1, 8] = new stageSRC(4,
new int[,] {
{0,0,0,0},
{0,3,3,0},
{0,3,3,0},
{0,0,0,0}
},
new int[,] {
{0,0,0,0},
{0,5,0,0},
{0,0,0,0},
{0,0,0,0}
},
new int[] { 0, 1, 1, 0, 0, 0, 0 },
new int[] { 0, 1, 0, 0, 1, 0, 0, 0, 0, 0 },
2
)

;
        stageDB[1, 9] = new stageSRC(4,
new int[,] {
{0,0,0,0},
{0,1,2,0},
{0,0,0,0},
{0,0,0,0}
},
new int[,] {
{0,0,0,0},
{0,1,2,0},
{0,1,2,0},
{0,0,0,0}
},
new int[] { 0, 0, 0, 1, 0, 0, 0 },
new int[] { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
1
)

;
        stageDB[1, 10] = new stageSRC(4,
new int[,] {
{1,5,5,5},
{3,0,0,0},
{3,0,0,0},
{3,0,0,0}
},
new int[,] {
{1,5,5,5},
{3,3,3,3},
{3,3,3,3},
{3,3,3,3}
},
new int[] { 0, 0, 0, 1, 0, 0, 0 },
new int[] { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
1
)

;

        stageDB[1, 11] = new stageSRC(4,
new int[,] {
{0,0,0,0},
{1,0,0,0},
{0,0,0,0},
{3,0,0,0}
},
new int[,] {
{0,0,0,0},
{1,1,1,1},
{0,0,0,0},
{3,3,3,3}
},
new int[] { 0, 0, 0, 2, 0, 0, 0 },
new int[] { 0, 0, 0, 0, 2, 0, 0, 0, 0, 0 },
2
)

;
        stageDB[1, 12] = new stageSRC(4,
new int[,] {
{0,0,0,0},
{0,2,2,0},
{0,2,2,0},
{0,0,0,0}
},
new int[,] {
{0,0,0,0},
{0,2,2,0},
{0,0,0,0},
{0,0,0,0}
},
new int[] { 0, 0, 0, 0, 1, 0, 0 },
new int[] { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
1
)

;
        stageDB[1, 13] = new stageSRC(4,
new int[,] {
{0,1,3,0},
{0,2,4,0},
{0,1,3,0},
{0,2,4,0}
},
new int[,] {
{0,0,0,0},
{0,0,0,0},
{0,1,3,0},
{0,2,4,0}
},
new int[] { 0, 0, 0, 0, 1, 0, 0 },
new int[] { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
1
)

;
        stageDB[1, 14] = new stageSRC(4,
new int[,] {
{0,1,3,0},
{0,2,4,0},
{0,1,3,0},
{0,2,5,0}
},
new int[,] {
{0,1,3,0},
{0,2,4,0},
{0,0,0,0},
{0,0,0,0}
},
new int[] { 0, 1, 1, 0, 1, 0, 0 },
new int[] { 0, 2, 1, 0, 0, 0, 0, 0, 0, 0 },
3
)

;
        stageDB[1, 15] = new stageSRC(4,
new int[,] {
{1,1,1,1},
{1,1,1,1},
{1,1,1,1},
{1,1,1,1}
},
new int[,] {
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0}
},
new int[] { 0, 0, 0, 0, 2, 0, 0 },
new int[] { 0, 0, 0, 0, 2, 0, 0, 0, 0, 0 },
2
)

;
        stageDB[1, 16] = new stageSRC(4,
new int[,] {
{0,0,0,0},
{0,1,0,0},
{0,0,0,0},
{0,0,0,0}
},
new int[,] {
{0,0,0,0},
{0,2,0,0},
{0,0,0,0},
{0,0,0,0}
},
new int[] { 0, 0, 0, 0, 0, 1, 0 },
new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
1
)

;
        stageDB[1, 17] = new stageSRC(4,
new int[,] {
{1,3,1,3},
{2,1,2,1},
{1,3,1,3},
{2,1,2,1}
},
new int[,] {
{1,1,1,1},
{1,1,1,1},
{1,1,1,1},
{1,1,1,1}
},
new int[] { 0, 0, 0, 0, 0, 2, 0 },
new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
2
)

;
        stageDB[1, 18] = new stageSRC(4,
new int[,] {
{1,1,1,1},
{1,1,1,1},
{1,1,1,1},
{1,1,1,1}
},
new int[,] {
{1,1,0,1},
{1,1,0,1},
{1,1,0,1},
{1,1,0,1}
},
new int[] { 0, 0, 0, 0, 0, 0, 1 },
new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
1
)

;
        stageDB[1, 19] = new stageSRC(4,
new int[,] {
{1,5,4,3},
{2,1,5,4},
{3,2,1,5},
{4,3,2,1}
},
new int[,] {
{1,0,4,3},
{0,0,0,0},
{3,0,1,5},
{4,0,2,1}
},
new int[] { 0, 0, 0, 0, 0, 0, 2 },
new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
2
)

;
        stageDB[1, 20] = new stageSRC(4,
new int[,] {
{0,0,0,1},
{0,0,0,2},
{0,0,0,3},
{0,0,0,4}
},
new int[,] {
{0,1,0,1},
{0,2,0,2},
{0,3,0,3},
{0,4,0,4}
},
new int[] { 0, 0, 0, 1, 0, 0, 1 },
new int[] { 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
2
)

;

        stageDB[2, 1] = new stageSRC(4,
new int[,] {
{0,0,0,0},
{0,1,0,3},
{0,0,0,0},
{0,0,0,0}
},
new int[,] {
{0,0,0,0},
{0,1,2,0},
{0,1,2,0},
{0,0,0,0}
},
new int[] { 0, 1, 1, 1, 0, 0, 0 },
new int[] { 0, 2, 1, 0, 0, 0, 0, 0, 0, 0 },
3
)

;
        stageDB[2, 2] = new stageSRC(4,
new int[,] {
{0,0,0,0},
{1,3,0,0},
{1,3,0,0},
{0,0,0,0}
},
new int[,] {
{0,0,0,0},
{1,3,3,1},
{1,3,3,1},
{0,0,0,0}
},
new int[] { 0, 0, 1, 1, 0, 1, 0 },
new int[] { 0, 0, 1, 0, 1, 0, 0, 0, 0, 0 },
3
)

;
        stageDB[2, 3] = new stageSRC(4,
new int[,] {
{0,0,0,0},
{0,4,4,0},
{0,0,0,0},
{0,0,0,0}
},
new int[,] {
{0,0,0,0},
{4,0,4,0},
{4,0,4,0},
{4,0,4,0}
},
new int[] { 0, 1, 0, 1, 1, 0, 0 },
new int[] { 0, 1, 1, 1, 0, 0, 0, 0, 0, 0 },
3
)

;
        stageDB[2, 4] = new stageSRC(4,
new int[,] {
{3,5,0,0},
{2,1,0,0},
{0,0,0,0},
{0,0,0,0}
},
new int[,] {
{0,0,0,0},
{0,0,0,0},
{0,0,3,5},
{0,0,2,1}
},
new int[] { 0, 0, 0, 2, 2, 0, 0 },
new int[] { 0, 0, 4, 0, 0, 0, 0, 0, 0, 0 },
4
)

;
        stageDB[2, 5] = new stageSRC(4,
new int[,] {
{3,0,0,0},
{3,0,0,0},
{0,0,0,5},
{0,0,0,5}
},
new int[,] {
{0,0,0,0},
{0,0,3,0},
{0,0,1,5},
{0,0,0,0}
},
new int[] { 0, 1, 1, 1, 2, 0, 0 },
new int[] { 0, 1, 2, 2, 0, 0, 0, 0, 0, 0 },
5
)

;
        stageDB[2, 6] = new stageSRC(4,
new int[,] {
{3,5,0,0},
{3,5,0,0},
{0,0,0,0},
{0,0,0,0}
},
new int[,] {
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0}
},
new int[] { 0, 0, 0, 2, 2, 0, 0 },
new int[] { 0, 0, 4, 0, 0, 0, 0, 0, 0, 0 },
4
)

;
        stageDB[2, 7] = new stageSRC(4,
new int[,] {
{2,3,4,5},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0}
},
new int[,] {
{2,3,4,5},
{0,0,0,0},
{0,0,0,0},
{2,3,4,5}
},
new int[] { 0, 0, 0, 1, 1, 0, 1 },
new int[] { 0, 0, 1, 0, 1, 0, 0, 0, 0, 0 },
3
)

;
        stageDB[2, 8] = new stageSRC(4,
new int[,] {
{1,0,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,3}
},
new int[,] {
{0,0,0,1},
{0,0,0,0},
{0,0,0,0},
{3,0,0,0}
},
new int[] { 0, 0, 0, 2, 2, 0, 0 },
new int[] { 0, 0, 0, 0, 4, 0, 0, 0, 0, 0 },
4
)

;
        stageDB[2, 9] = new stageSRC(6,
new int[,] {
{1,1,4,4,0,0},
{3,3,5,5,2,2},
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0}
},
new int[,] {
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{1,1,4,4,2,2},
{3,3,5,5,0,0}
},
new int[] { 0, 1, 1, 1, 1, 0, 0 },
new int[] { 0, 0, 2, 2, 0, 0, 0, 0, 0, 0 },
4
)

;
        stageDB[2, 10] = new stageSRC(6,
new int[,] {
{1,0,0,0,0,0},
{1,2,0,0,0,0},
{1,2,3,0,0,0},
{1,2,3,0,0,0},
{1,2,3,0,0,0},
{1,2,3,0,0,0}
},
new int[,] {
{1,0,0,0,0,0},
{1,2,0,0,0,0},
{1,2,3,0,0,0},
{1,2,3,1,0,0},
{1,2,3,1,2,0},
{1,2,3,1,2,3}
},
new int[] { 0, 0, 2, 1, 0, 0, 0 },
new int[] { 0, 1, 2, 0, 0, 0, 0, 0, 0, 0 },
3
)

;
        stageDB[2, 11] = new stageSRC(6,
new int[,] {
{1,0,0,0,0,0},
{0,2,2,0,0,0},
{0,2,3,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0}
},
new int[,] {
{1,0,0,0,0,1},
{0,2,2,2,2,0},
{0,2,3,3,2,0},
{0,2,3,3,2,0},
{0,2,2,2,2,0},
{1,0,0,0,0,1}
},
new int[] { 0, 4, 1, 2, 0, 1, 0 },
new int[] { 0, 5, 2, 0, 0, 0, 0, 0, 0, 0 },
8
)

;
        stageDB[2, 12] = new stageSRC(6,
new int[,] {
{1,3,3,0,0,0},
{1,3,5,0,0,0},
{4,4,5,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0}
},
new int[,] {
{1,3,3,1,3,3},
{1,2,5,1,2,5},
{4,4,5,4,4,5},
{1,3,3,1,3,3},
{1,2,5,1,2,5},
{4,4,5,4,4,5}
},
new int[] { 0, 0, 0, 2, 0, 1, 0 },
new int[] { 0, 0, 2, 0, 0, 0, 0, 0, 0, 0 },
3
)

;
        stageDB[2, 13] = new stageSRC(6,
new int[,] {
{1,1,1,1,0,0},
{1,1,1,1,0,0},
{0,3,3,3,3,0},
{0,3,3,3,3,0},
{0,0,5,5,5,5},
{0,0,5,5,5,5}
},
new int[,] {
{1,0,0,1,0,0},
{1,0,0,1,0,0},
{0,0,0,3,3,0},
{0,3,3,0,0,0},
{0,0,5,0,0,5},
{0,0,5,0,0,5}
},
new int[] { 0, 0, 0, 0, 4, 0, 0 },
new int[] { 0, 0, 0, 4, 0, 0, 0, 0, 0, 0 },
4
)

;
        stageDB[2, 14] = new stageSRC(6,
new int[,] {
{1,0,0,0,0,0},
{1,0,4,4,4,3},
{1,0,5,0,0,3},
{1,0,5,1,0,3},
{1,0,0,0,0,3},
{1,2,2,2,2,2}
},
new int[,] {
{1,0,0,0,0,0},
{1,1,4,4,4,3},
{1,1,5,4,3,3},
{1,1,5,1,3,3},
{1,1,2,2,2,3},
{1,2,2,2,2,2}
},
new int[] { 0, 0, 0, 4, 0, 0, 0 },
new int[] { 0, 0, 4, 0, 0, 0, 0, 0, 0, 0 },
4
)

;
        stageDB[2, 15] = new stageSRC(6,
new int[,] {
{1,1,1,1,1,1},
{1,1,1,1,1,1},
{1,1,1,1,1,1},
{1,1,1,1,1,1},
{1,1,1,1,1,1},
{1,1,1,1,1,1}
},
new int[,] {
{1,1,1,1,1,1},
{1,2,3,3,2,1},
{1,2,3,3,2,1},
{1,4,3,3,4,1},
{1,4,3,3,4,1},
{1,1,1,1,1,1}
},
new int[] { 0, 0, 0, 0, 0, 3, 0 },
new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
3
)

;
        stageDB[2, 16] = new stageSRC(6,
new int[,] {
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{0,0,1,3,0,0},
{0,0,3,1,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0}
},
new int[,] {
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{0,0,1,3,0,0},
{0,0,3,1,3,3},
{0,0,0,3,0,0},
{0,0,0,3,0,0}
},
new int[] { 0, 0, 1, 2, 0, 1, 0 },
new int[] { 0, 1, 0, 1, 1, 0, 0, 0, 0, 0 },
4
)

;
        stageDB[2, 17] = new stageSRC(6,
new int[,] {
{3,3,3,3,2,2},
{3,3,3,3,2,2},
{3,3,3,3,2,2},
{3,3,3,3,2,2},
{3,3,3,3,2,2},
{3,3,3,3,2,2}
},
new int[,] {
{3,3,3,3,2,2},
{3,4,4,4,2,2},
{3,4,3,3,2,2},
{3,4,3,3,2,2},
{3,4,4,4,2,2},
{3,3,3,3,2,2}
},
new int[] { 0, 1, 1, 0, 0, 1, 0 },
new int[] { 0, 0, 0, 0, 2, 0, 0, 0, 0, 0 },
3
)

;
        stageDB[2, 18] = new stageSRC(6,
new int[,] {
{0,0,0,1,1,0},
{0,0,1,2,2,1},
{1,1,2,2,0,0},
{1,2,2,2,0,0},
{0,1,2,2,2,1},
{0,0,1,1,1,0}
},
new int[,] {
{0,0,0,2,2,0},
{0,0,2,3,3,2},
{2,2,3,3,3,2},
{2,3,3,3,3,2},
{0,2,3,3,3,2},
{0,0,2,2,2,0}
},
new int[] { 0, 1, 0, 0, 0, 2, 0 },
new int[] { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
3
)

;
        stageDB[2, 19] = new stageSRC(8,
new int[,] {
{0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0},
{0,1,0,0,0,0,1,0},
{0,1,1,1,1,1,1,0},
{0,0,0,0,0,0,1,0},
{0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0}
},
new int[,] {
{0,0,0,0,0,0,0,0},
{0,0,0,1,0,0,0,0},
{0,0,0,1,1,1,1,0},
{0,1,0,1,0,0,1,0},
{0,1,1,1,3,3,1,0},
{0,0,1,0,0,0,1,0},
{0,0,1,1,1,1,1,1},
{0,0,1,0,0,0,0,0}
},
new int[] { 0, 0, 0, 4, 0, 1, 0 },
new int[] { 0, 0, 0, 0, 3, 0, 1, 0, 0, 0 },
5
)

;
        stageDB[2, 20] = new stageSRC(6,
new int[,] {
{5,5,0,0,0,0},
{5,5,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0}
},
new int[,] {
{5,5,5,5,0,0},
{5,5,5,5,0,0},
{0,0,5,5,5,5},
{0,0,5,5,5,5},
{0,0,0,0,5,5},
{0,0,0,0,5,5}
},
new int[] { 0, 0, 0, 3, 1, 0, 0 },
new int[] { 0, 0, 0, 4, 0, 0, 0, 0, 0, 0 },
4
)

;
        stageDB[2, 21] = new stageSRC(8,
new int[,] {
{1,0,0,0,0,0,0,0},
{1,0,0,0,0,0,0,0},
{1,0,0,0,0,0,0,0},
{1,0,0,0,0,0,0,0},
{1,0,0,0,0,0,0,0},
{1,0,0,0,0,0,0,0},
{1,0,0,0,0,0,0,0},
{1,1,1,1,1,1,1,1}
},
new int[,] {
{1,0,4,4,4,4,4,4},
{1,0,4,4,4,4,4,4},
{1,0,4,4,4,4,4,4},
{1,0,4,4,4,4,4,4},
{1,0,4,4,4,4,4,4},
{1,0,4,4,4,4,4,4},
{1,0,0,0,0,0,0,0},
{1,1,1,1,1,1,1,1}
},
new int[] { 0, 1, 0, 2, 0, 0, 0 },
new int[] { 0, 0, 2, 0, 0, 0, 0, 0, 0, 1 },
3
)

;
        stageDB[2, 22] = new stageSRC(8,
new int[,] {
{1,0,0,0,0,0,0,0},
{2,0,0,0,0,0,0,0},
{3,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0}
},
new int[,] {
{0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0},
{0,0,0,0,0,3,2,1}
},
new int[] { 0, 0, 0, 6, 6, 0, 0 },
new int[] { 0, 0, 0, 0, 0, 0, 4, 4, 4, 0 },
12
)

;
        stageDB[2, 23] = new stageSRC(8,
new int[,] {
{4,4,0,0,0,0,0,0},
{4,4,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0}
},
new int[,] {
{0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0},
{0,0,0,0,4,4,4,4}
},
new int[] { 0, 0, 0, 3, 3, 0, 0 },
new int[] { 0, 0, 2, 0, 4, 0, 0, 0, 0, 0 },
6
)

;
        stageDB[2, 24] = new stageSRC(8,
new int[,] {
{1,0,0,0,0,0,0,0},
{1,0,0,0,0,0,0,0},
{1,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,3},
{0,0,0,0,0,0,0,3},
{0,0,0,0,0,0,0,3}
},
new int[,] {
{1,0,0,0,0,0,1,0},
{1,0,0,0,0,0,1,0},
{1,0,0,0,0,0,1,0},
{0,4,4,4,4,4,4,0},
{0,5,5,5,5,5,5,0},
{0,3,0,0,0,0,0,3},
{0,3,0,0,0,0,0,3},
{0,3,0,0,0,0,0,3}
},
new int[] { 0, 2, 0, 2, 2, 0, 0 },
new int[] { 0, 0, 0, 0, 0, 0, 4, 2, 0, 0 },
6
)

;
        stageDB[2, 25] = new stageSRC(8,
new int[,] {
{0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0},
{0,2,2,2,2,0,0,0},
{0,0,0,4,2,0,0,0},
{0,0,0,4,2,0,0,0},
{0,0,0,4,4,4,4,0},
{0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0}
},
new int[,] {
{0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0},
{0,4,4,4,4,0,0,0},
{0,0,0,2,4,0,0,0},
{0,0,0,2,4,0,0,0},
{0,0,0,2,2,2,2,0},
{0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0}
},
new int[] { 0, 0, 0, 1, 1, 2, 0 },
new int[] { 0, 0, 0, 2, 0, 0, 0, 0, 0, 0 },
4
)

;
        stageDB[2, 31] = new stageSRC(6,
new int[,] {
{0,0,0,0,0,0},
{0,1,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0}
},
new int[,] {
{0,0,0,0,0,0},
{0,1,1,1,1,0},
{0,1,4,4,1,0},
{0,1,4,0,0,0},
{0,1,1,0,0,0},
{0,0,0,0,0,0}
},
new int[] { 0, 1, 0, 1, 1, 1, 0 },
new int[] { 0, 0, 1, 1, 1, 0, 0, 0, 0, 0 },
4
)

;
        stageDB[2, 32] = new stageSRC(6,
new int[,] {
{0,0,0,0,0,0},
{0,4,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0}
},
new int[,] {
{0,0,0,0,0,0},
{0,5,0,0,0,0},
{0,5,5,1,0,0},
{0,3,3,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0}
},
new int[] { 0, 2, 0, 0, 0, 2, 0 },
new int[] { 0, 0, 1, 1, 0, 0, 0, 0, 0, 0 },
4
)

;
        stageDB[2, 33] = new stageSRC(4,
new int[,] {
{0,0,0,0},
{0,2,0,0},
{0,0,0,0},
{0,0,0,0}
},
new int[,] {
{0,0,0,0},
{0,0,0,3},
{0,0,0,3},
{0,2,3,3}
},
new int[] { 0, 1, 0, 1, 1, 0, 0 },
new int[] { 0, 0, 1, 2, 0, 0, 0, 0, 0, 0 },
3
)

;
        stageDB[2, 34] = new stageSRC(4,
new int[,] {
{2,0,0,0},
{2,0,0,0},
{0,0,0,4},
{0,0,0,4}
},
new int[,] {
{0,0,2,2},
{0,0,2,2},
{0,0,4,4},
{0,0,4,4}
},
new int[] { 0, 4, 1, 2, 1, 0, 0 },
new int[] { 0, 0, 5, 0, 2, 0, 0, 0, 1, 0 },
8
)

;
        stageDB[2, 35] = new stageSRC(6,
new int[,] {
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{3,3,3,3,3,0}
},
new int[,] {
{0,0,0,0,0,0},
{0,3,3,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{3,1,1,3,3,0}
},
new int[] { 0, 1, 0, 1, 1, 0, 0 },
new int[] { 0, 0, 1, 0, 0, 2, 0, 0, 0, 0 },
3
)

;
        stageDB[2, 36] = new stageSRC(4,
new int[,] {
{0,0,0,0},
{0,0,0,0},
{0,2,2,0},
{0,2,2,0}
},
new int[,] {
{0,2,2,0},
{0,1,2,0},
{0,1,2,0},
{0,0,2,0}
},
new int[] { 0, 1, 0, 1, 1, 0, 0 },
new int[] { 0, 0, 2, 1, 0, 0, 0, 0, 0, 0 },
3
)

;
        stageDB[2, 37] = new stageSRC(4,
new int[,] {
{0,3,0,0},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0}
},
new int[,] {
{0,0,0,0},
{1,3,1,3},
{4,3,4,3},
{0,0,0,0}
},
new int[] { 0, 2, 1, 2, 0, 0, 0 },
new int[] { 0, 1, 2, 1, 1, 0, 0, 0, 0, 0 },
5
)

;
        stageDB[2, 38] = new stageSRC(4,
new int[,] {
{0,0,0,0},
{0,0,0,0},
{0,0,1,0},
{0,0,0,0}
},
new int[,] {
{0,1,0,0},
{0,1,0,0},
{0,1,3,0},
{0,0,0,0}
},
new int[] { 0, 2, 0, 0, 1, 0, 0 },
new int[] { 0, 1, 1, 1, 0, 0, 0, 0, 0, 0 },
3
)

;
        stageDB[2, 39] = new stageSRC(4,
new int[,] {
{1,1,1,1},
{0,0,0,0},
{0,0,0,0},
{0,0,0,0}
},
new int[,] {
{1,0,1,1},
{0,1,1,0},
{0,1,0,0},
{0,1,0,0}
},
new int[] { 0, 1, 1, 1, 0, 0, 0 },
new int[] { 0, 1, 1, 1, 0, 0, 0, 0, 0, 0 },
3
)

;
        stageDB[2, 40] = new stageSRC(4,
new int[,] {
{0,3,0,0},
{0,3,0,0},
{0,3,0,0},
{0,3,0,0}
},
new int[,] {
{0,3,0,0},
{0,3,3,3},
{0,1,0,0},
{0,3,0,0}
},
new int[] { 0, 1, 0, 1, 0, 0, 1 },
new int[] { 0, 1, 0, 1, 0, 0, 0, 0, 0, 0 },
3
)

;
        stageDB[2, 41] = new stageSRC(6,
new int[,] {
{5,5,5,0,0,0},
{5,5,5,0,0,0},
{5,5,5,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0}
},
new int[,] {
{5,5,5,5,5,5},
{5,2,5,5,3,5},
{5,5,5,5,5,5},
{5,5,5,5,5,5},
{5,2,5,5,2,5},
{5,5,5,5,5,5}
},
new int[] { 0, 1, 1, 2, 0, 1, 0 },
new int[] { 0, 2, 2, 0, 0, 0, 0, 0, 0, 0 },
5
)

;
        stageDB[2, 42] = new stageSRC(6,
new int[,] {
{0,2,2,2,0,0},
{0,2,2,2,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0}
},
new int[,] {
{0,0,0,0,0,0},
{0,2,2,2,2,0},
{0,0,0,2,2,0},
{0,0,0,0,2,0},
{0,0,0,0,2,0},
{0,0,0,0,2,0}
},
new int[] { 0, 3, 0, 0, 1, 0, 0 },
new int[] { 0, 2, 1, 0, 1, 0, 0, 0, 0, 0 },
4
)

;
        stageDB[2, 43] = new stageSRC(6,
new int[,] {
{0,0,0,0,0,1},
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{3,0,0,0,0,0}
},
new int[,] {
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,3}
},
new int[] { 0, 0, 1, 1, 1, 0, 0 },
new int[] { 0, 1, 0, 0, 0, 0, 2, 0, 0, 0 },
3
)

;
        stageDB[2, 44] = new stageSRC(6,
new int[,] {
{2,0,0,0,0,0},
{2,0,0,0,0,0},
{2,0,0,0,0,0},
{2,0,0,0,0,0},
{2,0,0,0,0,0},
{2,0,0,0,0,0}
},
new int[,] {
{2,0,0,0,0,0},
{2,2,2,2,0,0},
{2,0,0,2,0,0},
{2,0,0,2,0,0},
{2,2,2,2,0,0},
{2,0,0,0,0,0}
},
new int[] { 0, 0, 1, 1, 1, 0, 0 },
new int[] { 0, 0, 1, 0, 1, 1, 0, 0, 0, 0 },
3
)

;
        stageDB[2, 45] = new stageSRC(4,
new int[,] {
{0,0,0,0},
{0,0,0,0},
{0,0,5,5},
{0,0,5,5}
},
new int[,] {
{0,0,0,0},
{0,0,0,0},
{0,0,0,0},
{3,3,5,5}
},
new int[] { 0, 2, 0, 0, 1, 0, 0 },
new int[] { 0, 0, 1, 1, 0, 0, 1, 0, 0, 0 },
3
)

;
        stageDB[2, 46] = new stageSRC(6,
new int[,] {
{2,0,0,0,0,5},
{2,0,0,0,0,5},
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{4,0,0,0,0,3},
{4,0,0,0,0,3}
},
new int[,] {
{2,2,0,0,0,0},
{2,2,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,3,3},
{0,0,0,0,3,3}
},
new int[] { 0, 1, 0, 1, 2, 2, 0 },
new int[] { 0, 0, 0, 2, 0, 1, 0, 0, 1, 0 },
6
)

;
        stageDB[2, 47] = new stageSRC(6,
new int[,] {
{0,0,0,1,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0}
},
new int[,] {
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,1,0,0},
{0,0,0,1,0,0},
{0,0,0,1,0,0},
{0,0,0,1,0,0}
},
new int[] { 0, 1, 0, 1, 1, 0, 0 },
new int[] { 0, 1, 1, 1, 0, 0, 0, 0, 0, 0 },
3
)

;
        stageDB[2, 48] = new stageSRC(6,
new int[,] {
{0,0,0,0,3,3},
{0,0,0,0,3,3},
{0,0,0,0,3,3},
{0,0,0,0,3,3},
{0,0,0,0,0,0},
{0,0,0,0,0,0}
},
new int[,] {
{0,0,0,0,3,3},
{0,0,0,0,3,3},
{3,3,1,1,3,3},
{3,3,1,1,3,3},
{0,0,0,0,0,0},
{0,0,0,0,0,0}
},
new int[] { 0, 0, 0, 1, 0, 1, 0 },
new int[] { 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
2
)

;
        stageDB[2, 49] = new stageSRC(4,
new int[,] {
{0,0,0,0},
{0,0,0,0},
{0,0,2,2},
{0,0,2,2}
},
new int[,] {
{0,0,0,0},
{0,0,0,0},
{2,2,2,2},
{0,2,4,2}
},
new int[] { 0, 3, 1, 0, 0, 0, 0 },
new int[] { 0, 3, 1, 0, 0, 0, 0, 0, 0, 0 },
4
)

;
        stageDB[2, 50] = new stageSRC(4,
new int[,] {
{0,0,0,0},
{0,3,3,3},
{0,3,3,3},
{0,3,3,3}
},
new int[,] {
{0,3,3,3},
{0,3,3,3},
{0,1,1,1},
{0,3,3,3}
},
new int[] { 0, 1, 0, 1, 1, 0, 1 },
new int[] { 0, 0, 0, 2, 1, 0, 0, 0, 0, 0 },
4
)

;
        stageDB[2, 26] = new stageSRC(6,
new int[,] {
{2,3,3,3,3,3},
{2,0,0,0,0,0},
{2,0,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0},
{0,0,0,0,0,0}
},
new int[,] {
{2,3,3,3,0,3},
{2,1,1,3,0,0},
{2,1,1,3,0,0},
{2,1,1,3,0,0},
{2,1,1,3,0,0},
{0,0,0,0,0,0}
},
new int[] { 0, 2, 0, 1, 1, 0, 0 },
new int[] { 0, 0, 2, 0, 2, 0, 0, 0, 0, 0 },
4
)

;
        stageDB[2, 27] = new stageSRC(4,
new int[,] {
{0,4,4,0},
{0,4,4,0},
{0,4,4,0},
{0,4,4,0}
},
new int[,] {
{0,4,4,3},
{0,0,0,2},
{0,0,0,2},
{0,0,0,2}
},
new int[] { 0, 2, 0, 0, 2, 0, 0 },
new int[] { 0, 0, 0, 1, 2, 0, 0, 0, 0, 1 },
4
)

;
        stageDB[2, 28] = new stageSRC(6,
new int[,] {
{0,0,0,3,3,3},
{0,0,0,3,3,3},
{0,0,0,3,3,3},
{1,1,1,0,0,0},
{1,1,1,0,0,0},
{1,1,1,0,0,0}
},
new int[,] {
{0,0,3,3,3,3},
{0,0,0,0,0,0},
{1,0,0,0,0,0},
{1,0,0,0,0,0},
{1,0,0,0,0,0},
{1,0,0,0,0,0}
},
new int[] { 0, 3, 0, 1, 2, 0, 0 },
new int[] { 0, 1, 1, 1, 2, 1, 0, 0, 0, 0 },
6
)

;
        stageDB[2, 29] = new stageSRC(4,
new int[,] {
{0,0,0,0},
{0,0,0,0},
{0,2,2,2},
{0,2,2,2}
},
new int[,] {
{0,3,3,3},
{0,1,2,2},
{0,0,0,0},
{0,0,0,0}
},
new int[] { 0, 2, 0, 0, 1, 1, 0 },
new int[] { 0, 0, 0, 3, 0, 0, 0, 0, 0, 0 },
4
)

;
        stageDB[2, 30] = new stageSRC(6,
new int[,] {
{0,0,0,0,0,0},
{0,4,4,3,3,0},
{0,4,4,3,3,0},
{0,2,2,1,1,0},
{0,2,2,1,1,0},
{0,0,0,0,0,0}
},
new int[,] {
{0,0,0,0,0,0},
{0,4,5,5,3,0},
{0,4,5,5,3,0},
{0,2,5,5,1,0},
{0,2,5,5,1,0},
{0,0,0,0,0,0}
},
new int[] { 0, 2, 1, 0, 1, 0, 0 },
new int[] { 0, 0, 1, 0, 3, 0, 0, 0, 0, 0 },
4
)

;
    }


    

// Update is called once per frame
    void Update()
    {

    }
}