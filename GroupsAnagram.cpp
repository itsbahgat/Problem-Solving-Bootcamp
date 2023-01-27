class Solution {
public:
    vector<vector<string>> groupAnagrams(vector<string>& strs) {
           vector< vector<string> > result;
        map<string, multiset<string>> m;
        for(int i=0; i<strs.size(); i++){
            string word = strs[i];
            sort(word.begin(), word.end());
            m[word].insert(strs[i]);
        }
        
        for(auto item : m){
            vector<string> v(item.second.begin(), item.second.end());
            result.push_back(v);
        }
        return result;
    }
};
