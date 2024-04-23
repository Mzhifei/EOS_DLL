from os.path import exists


# EOSSDK-Win64-Shipping_native.h

def run(filename):
    if not exists(filename + ".h"):
        return
    eos_native_h = open(filename+ ".h", "r")

    toreplace = """_REPLACEME_
    {
        return _REPLACEMENOFN
    }
    """

    toreplace_void = """_REPLACEME_
    {
        _REPLACEMENOFN
    }
    """

    towrite = []


    for line in eos_native_h:
        if line.__contains__("DNNE_EXTERN_C DNNE_API") and line.__contains__(";"):
            if line.__contains__("void DNNE_CALLTYPE_STDCALL"):
                rep = toreplace_void
                rep = rep.replace("_REPLACEME_", line.replace("_EOS_", "EOS_").replace(";\n",""))
                splitted = line.split("DNNE_CALLTYPE_STDCALL ")[1]
                funcname = splitted.split("(")[0]
                write_arg = []
                args = splitted.split("(")[1].split(")")[0].split(" ")
                i = 0
                for arg in args:
                    if i % 2:
                        write_arg.append(arg)
                    i+=1
                func = (funcname + "(" + " ".join(write_arg) + ");")
                rep = rep.replace("_REPLACEMENOFN", func)
                towrite.append(rep + "\n")
            else:
                rep = toreplace
                rep = rep.replace("_REPLACEME_", line.replace("_EOS_", "EOS_").replace(";\n",""))
                splitted = line.split("DNNE_CALLTYPE_STDCALL ")[1]
                funcname = splitted.split("(")[0]
                write_arg = []
                args = splitted.split("(")[1].split(")")[0].split(" ")
                i = 0
                for arg in args:
                    if i % 2:
                        write_arg.append(arg)
                    i+=1
                func = (funcname + "(" + " ".join(write_arg) + ");")
                rep = rep.replace("_REPLACEMENOFN", func)
                towrite.append(rep + "\n")
                

    f = open(filename + ".cpp", "w")
    f.write("#include \""+ filename + ".h\"\n\n")
    for w in towrite:
        f.write(w)
    f.close()

if __name__ == "__main__":
    runners = ["EOSSDK-Win32-Shipping_native", "EOSSDK-Win64-Shipping_native", ""]
    for run_this in runners:
        run(run_this)