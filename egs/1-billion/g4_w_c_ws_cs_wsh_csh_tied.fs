w[1:4]  0002 // word 4gram
c[1:4]   0000 // class 4gram
w[1]-[1]w[1]	 2
w[1]-[2]w[1]  2
w[2]-[1]w[1]  2
w[1]-[1]w[2]  2
c[1]-[1]c[1]   0
c[1]-[2]c[1]   0
c[2]-[1]c[1]   0
c[1]-[1]c[2]   0
// long-skip bigram
w[1]-[3]w[1]  2
w[1]-[4]w[1]  2
c[1]-[3]c[1]   0
c[1]-[4]c[1]   0
// tied long-skip bigram
w[1]-[5:8]w[1]  2
c[1]-[5:8]c[1]   0


