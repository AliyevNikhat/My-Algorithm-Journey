class Solution {
public:
    ListNode* deleteDuplicates(ListNode* head) {
        if(head == NULL){
            return head;
        }
        ListNode *temp;
        ListNode *prev;
        ListNode *current = (ListNode*)malloc(sizeof(ListNode));
        ListNode* temp2 = current;
        temp = head;
        prev=temp;
        temp=temp->next;
        while(temp != NULL){
            if(prev->val != temp->val){
                temp2->next = prev;
                temp2=temp2->next;
            }
            prev = temp;
            temp = temp->next;
        }
        temp2->next=prev;
        ListNode * result = current->next;
        free(current);
        return result;
    }
};