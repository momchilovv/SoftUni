<?php
/**
 * Created by PhpStorm.
 * User: Cvetelin Momchilov
 * Date: 11/23/2017
 * Time: 14:45
 */
namespace CalculatorBundle\Entity;

class Calculator{
    private $leftOperand;
    private $rightOperand;
    private $operator;

    public function getLeftOperand(){
        return $this->leftOperand;
    }
    public function setLeftOperand($operand){
        $this->leftOperand = $operand;

        return $this;
    }
    public  function getRightOperand(){
        return $this->rightOperand;
    }
    public function setRightOperand($operand){
        $this->rightOperand = $operand;

        return $this;
    }
    public function getOperator(){
        return $this->operator;
    }
    public function setOperator($operand){
        $this->operator = $operand;

        return $this;
    }
}
