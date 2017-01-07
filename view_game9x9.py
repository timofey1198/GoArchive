f = open('E://1.sgf')

allstr = f.read()

ss = allstr.split('(')
ss = ss[1].split(')')
sss = ss[0].split(';')
sss = sss[1:]

settings = sss[0]
game_log = sss[1:]

convert = {'a':0, 'b':1, 'c':2, 'd':3, 'e':4, 'f':5, 'g':6, 'h':7, 'i':8}

#print(settings)

game = [['.' for i in range(9)] for j in range(9)]


def Print():
    for st in game:
        for x in st:
            print(x, end=' ')
        print()


Print()

for move in game_log:
    if '[]' in move:
        break
    x = convert[move[2]]
    y = convert[move[3]]
    print('(',x+1,'; ',y+1,')',sep='')
    if move[0] == 'B':
        game[x][y] = 'X'
    else:
        game[x][y] = '0'
    Print()
    input()