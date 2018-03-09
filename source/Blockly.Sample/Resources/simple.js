'use strict';

Blockly.JavaScript.INFINITE_LOOP_TRAP = 'if(--window.LoopTrap == 0) throw "Infinite loop.";\n';

Blockly.JavaScript['fable_set_module_motor_position'] = function (block) {
    var x = Blockly.JavaScript.valueToCode(block, 'MOTOR_POSITION_X', Blockly.JavaScript.ORDER_NONE) || '0';
    var y = Blockly.JavaScript.valueToCode(block, 'MOTOR_POSITION_Y', Blockly.JavaScript.ORDER_NONE) || '0';
    var m = block.getFieldValue('MOUDULE');
    return 'X: ' + x + ' ' + 'Y: ' + y + ' ' + 'Module: ' + m;
};