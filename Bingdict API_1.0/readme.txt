Interface:string a = await LexiconQuery.GetLexicon(query);
    input:a word(string)
    output:some word seperated by "$$"(string);


note:1.every word between a pair of "$$" mean a kind of meaning of the word;the standrad
       format will be discussed with yuying;
     2.the code is writed by C#,complie with x86;Encapsulate it with C++ if needed;
     3.the vision 1.0 couldn't tell the network connection,and it's unstable when your input is not a single word;
     4.try it and find more bug!