#include <stdio.h>

int status = 0;
int status_limit = 0;
int jukurendo = 0;
int danketsuryoku = 0;
int status_count = 0;
int status_limit_count = 0;
int required_status_point = 0;
int required_limit_point = 0;
int required_status_danketsuryoku_point = 0;
int required_limit_danketsuryoku_point = 0;
int retry_flag = 0;

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
	while (1) {
		while(1){
			printf("�ȉ��̏�����6�̃p�����[�^������͂��Ă�������\n");
			printf("���݂̓����X�e�[�^�X ���݂̓����X�e�[�^�X��� �����n���x �c���� ���݂̓����X�e�[�^�X������ ���݂̏��������\n\n");
			scanf_s("%d %d %d %d %d %d", &status, &status_limit, &jukurendo, &danketsuryoku, &status_count, &status_limit_count);
			if ((0 <= status && status <= 5000) && (500 <= status_limit && status_limit <=5000) && (0 <= jukurendo && jukurendo <= 9999) && (0 <= danketsuryoku && danketsuryoku <= 9999)&&(0 <= status_count && status_count <=230) && (0 <= status_limit_count && status_limit_count <= 140)){
			break;
			}
			else {
				scanf_s("%*[^\n]");
				scanf_s("%*c");
				printf("������������͂��Ă�������\n");
				status = 0;
				status_limit = 0;
				jukurendo = 0;
				danketsuryoku = 0;
				status_count = 0;
				status_limit_count = 0;
			}
		}


		while ((jukurendo - required_status_point >= 0 && danketsuryoku - required_status_danketsuryoku_point >= 0) || (jukurendo - required_limit_point >= 0 && danketsuryoku - required_limit_danketsuryoku_point >=0)&&(status_count < 230)) {
			required_point(status_count, required_status_point, required_status_danketsuryoku_point, &status_count, &required_status_point, &required_status_danketsuryoku_point);
			required_point(status_limit_count, required_limit_point, required_limit_danketsuryoku_point, &status_limit_count, &required_limit_point, &required_limit_danketsuryoku_point);
			//printf("�e�X�g�\��%d %d %d %d %d %d\n",status_count, required_status_point, required_status_danketsuryoku_point, status_limit_count, required_limit_point, required_limit_danketsuryoku_point);
			//printf("�e�X�g�\��%d %d %d %d %d %d\n", status, status_limit, jukurendo, required_status_point, danketsuryoku, required_status_danketsuryoku_point);
			if (((status + 10) <= status_limit) && ((jukurendo - required_status_point) >= 0) && ((danketsuryoku - required_status_danketsuryoku_point) >= 0) && (status_count < 230)) {
				//puts("�X�e�[�^�X��������\n");
				status = status + 10;
				jukurendo = jukurendo - required_status_point;
				danketsuryoku = danketsuryoku - required_status_danketsuryoku_point;
				status_count++;
			}
			else if (((jukurendo - required_limit_point) >= 0) &&((status_limit - status) <= 10) &&((jukurendo - 2*required_status_point)>=0) && ((danketsuryoku - required_limit_danketsuryoku_point) >= 0) && (status_limit_count < 140)) {
				//puts("�����������\n");
				status_limit = status_limit + 10;
				jukurendo = jukurendo - required_limit_point;
				danketsuryoku = danketsuryoku - required_limit_danketsuryoku_point;
				status_limit_count++;

			}
			else if((status < status_limit) && ((jukurendo - required_status_point) >= 0) && ((danketsuryoku - required_status_danketsuryoku_point) >= 0)&&(status_count < 230)){
				//puts("�X�e�[�^�X��������(����ȏ������グ�Ă��Ӗ����Ȃ��ꍇ)\n");
				status = status_limit;
				jukurendo = jukurendo - required_status_point;
				danketsuryoku = danketsuryoku - required_status_danketsuryoku_point;
				status_count++;
			}
			else {
				//puts("Break����(�������[�v�h�~�p)\n");
				break;
			}

		}
		printf("�ŏI�I�ȍő�X�e�[�^�X����\n");
		printf("�����X�e�[�^�X�F%d\n", status);
		printf("��������F%d\n", status_limit);
		printf("�݌v�����X�e�[�^�X������:%d\n", status_count);
		printf("�݌v�������������:%d\n", status_limit_count);
		printf("�c��n���x�F%d\n", jukurendo);
		printf("�c��c���́F%d\n", danketsuryoku);

		retry_flag = 0;
		printf("\n\"1\"������ȊO�̐��l����͂��Ă�������\n1:����1����s����B\n����ȊO�̐��l:�v���O�������I������B\n");
		scanf_s("%d", &retry_flag);
		if (retry_flag != 1) {
			break;
		}

	}
}