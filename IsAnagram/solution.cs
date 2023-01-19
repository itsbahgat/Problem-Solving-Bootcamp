public bool IsAnagram(string s, string t) {
        if(s.Length == t.Length){
            int[] sLetters = new int[26];
            int[] tLetters = new int[26];

            for(int i=0; i<s.Length; i++){
                sLetters[s[i]-'a']++;
                tLetters[t[i]-'a']++;
            }

            for(int i=0; i<26; i++){
                if(sLetters[i] != tLetters[i]){
                    return false;
                }
            }
        }else{
            return false;
        }

        return true;
    }
