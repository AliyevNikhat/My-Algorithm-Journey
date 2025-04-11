class Solution {
public:
    ListNode* rotateRight(ListNode* head, int k) {
        if(head == NULL || head->next == NULL){
            return head;
        }
        ListNode *current, *prev, *temp2, *count;
        count = head;
        int LinkedListCount=1;
        while(count->next!=NULL){
            LinkedListCount++;
            count=count->next;
        }
        if(k > LinkedListCount)
        {
            k%=LinkedListCount;
        }
        while(0 < k){
            current = head;
            temp2 = head;
            prev = NULL;
            while(current->next != NULL){
                current = current->next;
                prev=temp2;
                temp2=temp2->next;
            }
            current->next=head;
            head = current;
            prev->next=NULL;
            k--;
        }
        return head;
    }
};