#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

int status = 0;
int status_limit = 0;
int jukurendo = 0;
int danketsuryoku = 0;
int status_count = 0;
int status_limit_count = 0;
int requrired_status_point = 0;
int requrired_limit_point = 0;
int requrired_status_danketsuryoku_point = 0;
int requrired_limit_danketsuryoku_point = 0;

int required_point(int count, int point, int danketsuryoku_point,int *p_count,int *p_point, int *p_danketsuryoku_point){
	if (0 <= count && count <30) {
		point = 10;
		danketsuryoku_point = 0;
	}
	else if (30 <= count && count < 60) {
		point = 15;
		danketsuryoku_point = 0;
	}
	else if (60 <= count && count < 90) {
		point = 20;
		danketsuryoku_point = 1;
	}
	else if (90 <= count && count < 120) {
		point = 30;
		danketsuryoku_point = 2;
	}
	else if (120 <= count && count < 150) {
		point = 40;
		danketsuryoku_point = 3;
	}
	else if (150 <= count && count < 230) {
		point = 50;
		danketsuryoku_point = 4;
	}
	*p_count = count;
	*p_point = point;
	*p_danketsuryoku_point = danketsuryoku_point;
	return 0;
}

int main(void) {
	printf("�ȉ��̏����ŏ�����͂��Ă�������\n");
	printf("���݂̓����X�e�[�^�X ���݂̓����X�e�[�^�X��� �����n���x �c���� ���݂̓����X�e�[�^�X������ ���݂̏��������\n\n");
	(void)scanf("%d %d %d %d %d %d", &status, &status_limit, &jukurendo, &danketsuryoku, &status_count, &status_limit_count);

	while ((jukurendo - requrired_status_point >= 0 && danketsuryoku - requrired_status_danketsuryoku_point >= 0) || (jukurendo - requrired_limit_point >= 0 && danketsuryoku - requrired_limit_danketsuryoku_point >=0)&&(status_count < 230)) {
		required_point(status_count, requrired_status_point, requrired_status_danketsuryoku_point, &status_count, &requrired_status_point, &requrired_status_danketsuryoku_point);
		required_point(status_limit_count, requrired_limit_point, requrired_limit_danketsuryoku_point, &status_limit_count, &requrired_limit_point, &requrired_limit_danketsuryoku_point);
		//printf("�e�X�g�\��%d %d %d %d %d %d\n",status_count, requrired_status_point, requrired_status_danketsuryoku_point, status_limit_count, requrired_limit_point, requrired_limit_danketsuryoku_point);
		if (((status + 10) <= status_limit) && ((jukurendo - requrired_status_point) >= 0) && ((danketsuryoku - requrired_status_danketsuryoku_point) >= 0)) {
			//puts("�e�X�g����1\n");
			status = status + 10;
			jukurendo = jukurendo - requrired_status_point;
			danketsuryoku = danketsuryoku - requrired_status_danketsuryoku_point;
			status_count++;
		}
		else if (((jukurendo - requrired_limit_point) >= 0) && ((danketsuryoku - requrired_limit_danketsuryoku_point) >= 0) && (status_count < 230)) {
			//puts("�e�X�g����2\n");
			status_limit = status_limit + 10;
			jukurendo = jukurendo - requrired_limit_point;
			danketsuryoku = danketsuryoku - requrired_limit_danketsuryoku_point;
			status_limit_count++;
		}
		else if((status < status_limit) && ((jukurendo - requrired_status_point) >= 0) && ((danketsuryoku - requrired_status_danketsuryoku_point) >= 0)&&(status_count < 230)){
			//puts("�e�X�g����3\n");
			status = status_limit;
			jukurendo = jukurendo - requrired_status_point;
			danketsuryoku = danketsuryoku - requrired_status_danketsuryoku_point;
			status_count++;
		}
	}
	printf("�ŏI�I�ȃX�e�[�^�X����\n");
	printf("�����X�e�[�^�X�F%d\n", status);
	printf("��������F%d\n", status_limit);
	printf("�݌v�����X�e�[�^�X������:%d\n", status_count);
	printf("�݌v�������������:%d\n", status_limit_count);
	printf("�c��n���x�F%d\n", jukurendo);
	printf("�c��c���́F%d\n", danketsuryoku);

	int enter;
	scanf("%d", &enter);
}