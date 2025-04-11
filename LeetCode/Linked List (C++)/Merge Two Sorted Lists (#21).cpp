class Solution {
public:
    ListNode* mergeTwoLists(ListNode* list1, ListNode* list2) {
        ListNode *head;
        ListNode *temp;
        head = (ListNode*)malloc(sizeof(ListNode));
        temp=head;
        temp->next=NULL;
        while(list1!=NULL && list2!=NULL){
            if(list1->val >= list2->val){
                temp->next=list2;
                list2=list2->next;
            }else{
                temp->next=list1;
                list1=list1->next;
            }
            temp=temp->next;
        }
        if(list1!=NULL){
            temp->next =list1;
        }else{
            temp->next=list2;
        }
        ListNode* mergedHead = head->next;
        free(head);
        return mergedHead;
    }
};