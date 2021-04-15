import glob, re
def checkForSignatures():
    print("### Checking for virus signatures ###")
    programs = glob.glob("*.py")
    for p in programs:
        thisFileInfected = False
        file = open(p, "r")
        lines = file.readlines()
        file.close()
        for line in lines:
            if (re.search("^# starting virus code",line)):
                print("virus found in file {0}!!!".fromat(p))
                thisFileInfected = True
        if (thisFileInfected == False):
            print("{0} appears to be clean!".format(p))
    print("### End of section ###")
checkForSignatures()

