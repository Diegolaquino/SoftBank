import { Component, OnInit } from '@angular/core';
import { Customer } from '../Models/customer';
import { Router } from '@angular/router';
import * as Chart from 'chart.js';
import { BankStatement } from '../Models/bankStatement.model';
import { AccountTransationsService } from '../services/accounttransaction.service';
import { Observable } from 'rxjs/Observable';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  customer : Customer;

  PieChart : Chart;

  bankStatements : BankStatement[];

  constructor(private route: Router, private accounttransactionService: AccountTransationsService) { 
    
    
  }

  ngOnInit() {
    var dataUserInfo = sessionStorage.getItem('userInfo');

    if(dataUserInfo == null){
      this.route.navigate(['']);
    }

    var userInfo = JSON.parse(dataUserInfo);

    this.customer = userInfo.user;

    this.accounttransactionService.getBankStatements().subscribe(bankStatements => this.bankStatements = bankStatements);

    console.log("this.bankStatements");
    console.log(this.bankStatements);


    this.PieChart = new Chart ('pieChart', {
      type:'doughnut',
      data:{ 
        labels:["Vestuário", "Alimentação", "Transportes"],
        datasets:[{
          label: 'Vote Now',
          data:[139.12,620.25,438.07],
          backgroundColor:[
            'rgba(154, 192, 0, 0.9)',
            'rgba(60, 203, 218, 0.9)',
            'rgba(255, 186, 0, 0.9)',
            'rgba(230, 37, 140, 0.9)',
            'rgba(135, 2, 123, 0.9)',
            'rgba(79, 3, 79, 0.9)'
          ], 
          hoverBackgroundColor: 'black'
        }] 
      },
      options: {
            scales: {
                yAxes: [{
                  display: false,  
                  ticks: {
                        beginAtZero: true
                    },
                    gridLines:{
                      // color: 'rgba(0,0,0,0)'
                      display:false,
                      drawBorder:false
                    }
                }],
                xAxes:[{
                  display:false,
                  gridLines:{
                    // 
                    display: false,
                    drawBorder:false
                  }
                }

                ]
            },
            tooltips:{
              caretSize: 10
            }
        }
    }); }
  
  }
