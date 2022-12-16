# Baking application
accountNo = 0
CusName = ''
BCode = ''
Mobile = 0
Bal = 0


def createAcounts():
    AcountNo = int(input('enter account Number\t'))
    CusName = str(input('enter Name\t'))
    Bcode = int(input('enter Branch Code\t'))
    Mobile = int(input('enter Mobile Number\t'))
    Bal = int(input('enter current Balance\t'))


def ShowAcntDetails():
    print('AccountNO:\t', accountNo)
    print('CustomerNo:\t', CusName)
    print('BCode:\t', BCode)
    print('mobile:\t', Mobile)


def Deposit(amount):
    Bal = Bal + amount
    chckbalance()


def Withdraw(amount):
    Bal = Bal - amount
    chckbalance()


def chckbalance():
    print('current Balance:', Bal)


#_Main_#
print('1.Create account\n 2.Withdraw \n 3.Deposit \n 4.Check balance\n')
ch = int(input('select any option\n'))
if(ch == 1):
    createAcounts()
elif(ch == 2):
    amnt = int(input("Enter amount to withdraw\t"))
modelBuilder