public bool IsAnagram(string s, string t) {
        
        if(s.Length != t.Length){
            return false;
        }
        int[] letters = new int[26];

        for(int i=0; i<s.Length; i++){
            letters[s[i]-'a']++;
            letters[t[i]-'a']--;
        }

        for(int i=0; i<26; i++){
            if(letters[i] != 0){
                return false;
            }
        }

        return true;
        
    }
