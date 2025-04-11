class Solution {
public:
    ListNode* removeNthFromEnd(ListNode* head, int n) {
        int LinkedListCount=0, i=0;
        ListNode *current;
        current = head;
        while(current!=NULL){
            LinkedListCount++;
            current = current->next;
        }
        int removenodes = LinkedListCount - n;
        
        if(removenodes==0){
            ListNode *deleted = head;
            head = head->next;
            delete deleted;
            return head;
        }else{
            ListNode *temp=head;
            ListNode *prev=NULL;
            while(i < removenodes){
                prev = temp;
                temp=temp->next;
                i++;
            }
            if (prev != NULL && temp != NULL) {
                prev->next = temp->next;
                delete temp;
            }
            return head;
        }
    }
};