#include <stdio.h>

int status = 0;								//���݂̓����X�e�[�^�X�l
int status_limit = 0;						//���݂̓����X�e�[�^�X���
int jukurendo = 0;							//���݂̓����X�e�[�^�X�ɑΉ�����n���x(�̏���or���芴or�\����or�W����)
int danketsuryoku = 0;						//���݂̒c���͂̒l
int status_count = 0;						//�����X�e�[�^�X�̐�����
int status_limit_count = 0;					//�����X�e�[�^�X����̐�����
int required_status_point = 0;				//�X�e�[�^�X�̎��̐����ɕK�v�ȏn���x(�̏���or���芴or�\����or�W����)
int required_limit_point = 0;				//�X�e�[�^�X����̎��̐����ɕK�v�ȏn���x(�̏���or���芴or�\����or�W����)
int required_status_danketsuryoku_point = 0;//�X�e�[�^�X�̎��̐����ɕK�v�Ȓc����
int required_limit_danketsuryoku_point = 0;	//�X�e�[�^�X����̎��̐����ɕK�v�Ȓc����
int retry_flag = 0;							//�J��Ԃ����s�p�t���O

int initial_danketsuryoku = 0;				//�c���͂̏����l

/*�����X�e�[�^�Xor����̎��̐����ɕK�v�ȏn���x�ƒc���͂̒l��Ԃ��֐�*/
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
	while (1) {	//�J��Ԃ����s�p��while���[�v
		while(1){	//���͒l���ؗp��while���[�v
			printf("�ȉ��̏�����6�̃p�����[�^������͂��Ă�������\n");
			printf("���݂̓����X�e�[�^�X ���݂̓����X�e�[�^�X��� �����n���x �c���� ���݂̓����X�e�[�^�X������ ���݂̏��������\n\n");
			scanf_s("%d %d %d %d %d %d", &status, &status_limit, &jukurendo, &danketsuryoku, &status_count, &status_limit_count);
			if ((0 <= status && status <= 5000)								//�����X�e�[�^�X�̒l���͈͓����ǂ���
				&& (500 <= status_limit && status_limit <=5000)				//�����X�e�[�^�X����̒l���͈͓����ǂ���
				&& (0 <= jukurendo && jukurendo <= 9999)					//�n���x�̒l(�̏���or���芴or�\����or�W����)���͈͓����ǂ���
				&& (0 <= danketsuryoku && danketsuryoku <= 9999)			//�c���͂̒l���͈͓����ǂ���
				&& (0 <= status_count && status_count <=230)				//�����X�e�[�^�X�̒l���͈͓����ǂ���
				&& (0 <= status_limit_count && status_limit_count <= 140)){	//�����X�e�[�^�X����l�̒l���͈͓����ǂ���
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
		initial_danketsuryoku = danketsuryoku;

		while ((jukurendo - required_status_point >= 0 && danketsuryoku - required_status_danketsuryoku_point >= 0)							//�X�e�[�^�X�������ł���
			|| (jukurendo - required_limit_point >= 0 && danketsuryoku - required_limit_danketsuryoku_point >=0)&&(status_count < 230)) {	//or�X�e�[�^�X����l�������ł���ꍇ���s

			//�X�e�[�^�X�ƃX�e�[�^�X����l�̎��̐����ɕK�v�ȕK�v�n���xpt�y�ѕK�v�c���͂����߂�
			required_point(status_count, required_status_point, required_status_danketsuryoku_point, &status_count, &required_status_point, &required_status_danketsuryoku_point);
			required_point(status_limit_count, required_limit_point, required_limit_danketsuryoku_point, &status_limit_count, &required_limit_point, &required_limit_danketsuryoku_point);
			//printf("�e�X�g�\��%d %d %d %d %d %d\n",status_count, required_status_point, required_status_danketsuryoku_point, status_limit_count, required_limit_point, required_limit_danketsuryoku_point);
			//printf("�e�X�g�\��%d %d %d %d %d %d\n", status, status_limit, jukurendo, required_status_point, danketsuryoku, required_status_danketsuryoku_point);
			if (((status + 10) <= status_limit)									//�����X�e�[�^�X������l-10�̒l�Ő����ł���
				&& ((jukurendo - required_status_point) >= 0)					//���A�����X�e�[�^�X�̐����ɕK�v�ȏn���xpt��ێ����Ă���
				&& ((danketsuryoku - required_status_danketsuryoku_point) >= 0) //���A�����X�e�[�^�X�̐����ɕK�v�Ȓc����pt��ێ����Ă���
				&& (status_count < 230)) {										//���A�����X�e�[�^�X�̐����񐔂�230��(�J���X�g)�����̏ꍇ�A���s
				//puts("�X�e�[�^�X��������\n");
				status = status + 10;
				jukurendo = jukurendo - required_status_point;
				danketsuryoku = danketsuryoku - required_status_danketsuryoku_point;
				status_count++;
			}
			else if (((jukurendo - required_limit_point) >= 0)					//���if�������s���ꂸ�A�����X�e�[�^�X����l�̐����ɕK�v�ȏn���xpt��ێ����Ă���
				&&((status_limit - status) <= 10)								//���A���݂̓����X�e�[�^�X�Ə���l�̍���10�ȉ�
				&& ((jukurendo - 2*required_status_point)>=0)					//���A�n���x��2��̐����Ō͊����Ȃ�
				&& ((danketsuryoku - required_limit_danketsuryoku_point) >= 0)  //���A�����X�e�[�^�X����l�̐����ɕK�v�Ȓc����pt��ێ����Ă���
				&& (status_limit_count < 140)) {								//���A�����X�e�[�^�X����̐����񐔂�140��(�J���X�g)�����̏ꍇ�A���s
				//puts("�����������\n");
				status_limit = status_limit + 10;
				jukurendo = jukurendo - required_limit_point;
				danketsuryoku = danketsuryoku - required_limit_danketsuryoku_point;
				status_limit_count++;

			}
			else if((status < status_limit)										//��L��if���Aelse if�������s���ꂸ�A���݂̓����X�e�[�^�X�l������l�ȉ�
				&& ((jukurendo - required_status_point) >= 0)					//�����X�e�[�^�X�̐����ɕK�v�ȏn���xpt��ێ����Ă���
				&& ((danketsuryoku - required_status_danketsuryoku_point) >= 0) //���A�����X�e�[�^�X�̐����ɕK�v�Ȓc����pt��ێ����Ă���
				&& (status_count < 230)){										//���A�����X�e�[�^�X�̐����񐔂�230��(�J���X�g)�����̏ꍇ�A���s
				//puts("�X�e�[�^�X��������(����ȏ������グ�Ă��Ӗ����Ȃ��A����l�őł��~�߂ɂȂ�ꍇ)\n");
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
		printf("�����X�e�[�^�X:%d\n", status);
		printf("�������:%d\n", status_limit);
		printf("�݌v�����X�e�[�^�X������:%d\n", status_count);
		printf("�݌v�������������:%d\n", status_limit_count);
		printf("�c��n���x:%d\n", jukurendo);
		printf("�c��c����:%d\n", danketsuryoku);
		
		retry_flag = 0;
		printf("\n\"1\"������ȊO�̐��l����͂��Ă�������\n1:����1����s����B\n����ȊO�̐��l:�v���O�������I������B\n");
		scanf_s("%d", &retry_flag);
		if (retry_flag != 1) {
			break;
		}

		printf("SP�ϊ��\��:%d\n",danketsuryoku / 30);
		printf("SP�ϊ��l:%d\n", danketsuryoku / 30*10);
		printf("SP�ϊ���c��c����:%d\n", initial_danketsuryoku - 30*(danketsuryoku / 30));
		printf("��L��ڈ���SP�ɕϊ��A����p�l������������������x���s���Ă�������\n");
		puts("--------------------------------------------");

	}
}