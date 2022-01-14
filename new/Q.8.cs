public static double angle(int hour, int minute) {

        if (hour < 0 || minute < 0) {

            return -1;

        }

        if (hour == 12) {

            hour = 0;

        }

        if (minute == 60) {

            minute = 0;

            hour += 1;

        }

        double hourAngle = (hour * 60 + minute) * 0.5;

        double minAngle = minute * 6;

        double bwAngle = Math.abs(hourAngle - minAngle);

        return Math.min(360 - bwAngle, bwAngle);

 

    }


 