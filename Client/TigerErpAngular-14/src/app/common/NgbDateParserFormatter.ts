import { NgbDateParserFormatter, NgbDateStruct, NgbTimeStruct } from '@ng-bootstrap/ng-bootstrap';

import { Injectable } from '@angular/core';

@Injectable()
export class NgbDateCustomParserFormatter extends NgbDateParserFormatter {
    
        parse(value: string): NgbDateStruct {
            if (value) {
                const dateParts = value.trim().split('/');
                if (dateParts.length === 1 ) {
                    return { day: this.toInteger(dateParts[0]), month: 0, year: 0 };
                } else if (dateParts.length === 2 ) {
                    return { day: this.toInteger(dateParts[0]), month: this.toInteger(dateParts[1]), year: 0 };
                } else if (dateParts.length === 3 ) {
                    return { day: this.toInteger(dateParts[0]), month: this.toInteger(dateParts[1]), year: this.toInteger(dateParts[2]) };
                }
            }
            return {day:0,month:0,year:0};
        }
    
        format(date: NgbDateStruct): string {
            return  'tttt';
        }
    
        toInteger(value: any): number {
            return 10;
        }
    
    
        padNumber(value: number) {
            if (value) {
                return `0${value}`.slice(-2);
            } else {
                return '';
            }
        }
        padLeft(value:number, length:number):string{
            let val = value+'';
            while(val.length<length){val = '0'+val}
            return val;
        }
    
        ngbDateToString(ngbDate: NgbDateStruct): string {
            return ngbDate.day + '/' + ngbDate.month + '/' + ngbDate.year;
        }
    
        stringToNgbDate(date: string): NgbDateStruct {
            let myDate: Date = new Date(date);
            let ngbDate: NgbDateStruct = {
                year: myDate.getFullYear(),
                month: myDate.getMonth() + 1,
                day: myDate.getDate()
            };
            return ngbDate;
        }
        dateToNgbDate(date: Date): NgbDateStruct {
            let localDate  = new Date(date)
            let ngbCustomDate: NgbDateStruct = {year:0, month:0, day:0};
            ngbCustomDate.year = localDate.getFullYear();
            ngbCustomDate.month = localDate.getMonth()+1;
            ngbCustomDate.day = localDate.getDate();
            return ngbCustomDate;
        }
        ngbDateToDate(ngbDate: NgbDateStruct): Date {
            let date = new Date(ngbDate.year, ngbDate.month - 1, ngbDate.day);
            return date;
        }
        getDateToYyyymmdd(date: Date = new Date()): string {
            let yyyymmdd: string;
            yyyymmdd = date.getFullYear().toString() + (date.getMonth()+1 ).toString().padStart(2, '0') + date.getDate().toString().padStart(2, '0')
            return yyyymmdd;
        }
        getNgbDateToYyyymmdd(date: NgbDateStruct) {
            if (date != null) {
                let y = date.year;
                let m = this.padLeft(date.month, 2);
                let d = this.padLeft(date.day, 2);
                return y.toString() + m + d;
            }else{
                return "00000000";
            }
        }
        getNgbDateToYyyy_mm_dd(date: NgbDateStruct) {
                let y = date.year;
                let m = this.padLeft(date.month, 2);
                let d = this.padLeft(date.day, 2);
                return y.toString() + '-' + m + '-' + d;
            
    }
        getCurrentNgbDate(): NgbDateStruct {
            let date: Date = new Date();
            let ngbDate: NgbDateStruct = {
                year: date.getFullYear(),
                month: date.getMonth() + 1,
                day: date.getDate()
            }
            return ngbDate;
        }
        getDateDiff(fromDateNgb: NgbDateStruct, toDateNgb: NgbDateStruct): number {
            let fromDate = this.ngbDateToDate(fromDateNgb);
            let toDate = this.ngbDateToDate(toDateNgb);
            let diff = toDate.getTime() - fromDate.getTime() + 1000 * 3600 * 24;
            let totalDay = Math.ceil(diff / (1000 * 3600 * 24));
            return totalDay;
        }
    
        getStrToNgbTime(strTime: string): NgbTimeStruct {
            if (strTime != null && strTime != '') {
                let hhmmss = strTime.split(':');
                if (hhmmss.length == 3) {
                    let ngbTime: NgbTimeStruct = { hour: parseInt(hhmmss[0]), minute: parseInt(hhmmss[1]), second: parseInt(hhmmss[2]) }
                    return ngbTime;
                } else {
                    return { hour: 0, minute: 0, second: 0 }
                }
            } else {
                return { hour: 0, minute: 0, second: 0 }
            }
        }
    
          getYyyymmddToNgbDate(date:string){
              let ngbDate:NgbDateStruct = {year:0, month:0, day:0};
              if(date==null || date.length!=8){
                  return ngbDate;
              }
              let y = parseInt(date.substr(0,4));
              let m = parseInt(date.substr(4,2));
              let d = parseInt(date.substr(6,2));
              ngbDate ={year:y,month:m, day:d}
              return ngbDate;
          }
          getYyyymmddToDate(dateStr:string):Date{
    
            let date:Date=new Date();
            if(dateStr==null || dateStr.length!=8){
                return date;
            }
            let y = parseInt(dateStr.substr(0, 4));
            let m = parseInt(dateStr.substr(4, 2));
            let d = parseInt(dateStr.substr(6, 2));
            date.setFullYear(y);
            date.setMonth(m-1);
            date.setDate(d);
            return date;
        }
    
        // "yyyymmdd To mm/dd/yyyy" Bappy
        getYyyymmddToDateB(dateStr:string){
    
          var date = [ dateStr.slice(4, 6),"/", dateStr.slice(6, 8), "/",dateStr.slice(0, 4)].join('');
          return date;
      }
    
       // " mm/dd/yyyy to yyyymmdd" Bappy
       getDateToyyyyMMddB(dateStr:string){
    
        var date = [ dateStr.slice(6, 10),dateStr.slice(3,5),dateStr.slice(0, 2)].join('');
        return date;
    }
        getHhmmssToNgbTime(time: string) {
            let ngbTime: NgbTimeStruct;
            if (time == null || time.length != 6) {
                return '';
            }
            let h = parseInt(time.substr(0, 2));
            let m = parseInt(time.substr(2, 2));
            let s = parseInt(time.substr(4, 2));
            ngbTime = { hour: h, minute: m, second: s }
            return ngbTime;
        }
        getNgbTimeToStrTime(ngbTime:NgbTimeStruct){
            if(ngbTime==null){
                return '00:00:00';
            }
            let hour = ngbTime.hour.toString().padStart(2,'0');
            let min = ngbTime.minute.toString().padStart(2,'0');
            let sec = ngbTime.second.toString().padStart(2,'0');
            return hour+':'+min+':'+sec;
        }
    
    
    }