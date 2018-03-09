'use strict';

Blockly.JavaScript['fable_get_time'] = function(block) {
    return 'window.AndroidFunction.showToast("fable_get_time");'
};

Blockly.JavaScript['fable_get_microphone'] = function(block) {
    return 'window.SoundDetector.getAmplitude();'
};

Blockly.JavaScript['fable_get_module_motor_position'] = function(block) {
    var value = block.getFieldValue('MOTOR_ID');
    var value = block.getFieldValue('MOUDULE');

    return 'window.AndroidFunction.showToast("fable_get_module_motor_position");'
};

Blockly.JavaScript['fable_get_time'] = function(block) {
    return 'window.AndroidFunction.showToast("fable_get_time");'
};

Blockly.JavaScript['fable_set_module_rgb'] = function(block) {
    var value = block.getFieldValue('COLOUR');
    var value = block.getFieldValue('MOUDULE');
    return 'window.AndroidFunction.showToast("fable_set_module_rgb");'
};

Blockly.JavaScript['fable_play_sound'] = function(block) {
    var value = block.getFieldValue('SOUNDFILE');
    return 'window.SoundPlayer.playSound("' + value + '");'
};

Blockly.JavaScript['fable_set_module_buzzer'] = function(block) {
    var valueTone = block.getFieldValue('TONE');
    var valueModule = block.getFieldValue('MOUDULE');

    return 'window.AndroidFunction.showToast("fable_set_module_buzzer");'
};

Blockly.JavaScript['fable_set_module_motor_position'] = function(block) {
    var value = block.getFieldValue('MOTOR_POSITION');
    var value = block.getFieldValue('MOTOR_ID');
    var value = block.getFieldValue('MOUDULE');

    return 'window.AndroidFunction.showToast("fable_set_module_motor_position");'
};

Blockly.JavaScript['fable_set_module_motor_positions'] = function(block) {
    var value = block.getFieldValue('MOTOR_POSITION_X');
    var value = block.getFieldValue('MOTOR_POSITION_Y');
    var value = block.getFieldValue('MOUDULE');

    return 'window.AndroidFunction.showToast("fable_set_module_motor_positions");'
};

Blockly.JavaScript['fable_set_module_motor_pos_speed'] = function(block) {
    var value = block.getFieldValue('MOTOR_POSITION_X');
    var value = block.getFieldValue('MOTOR_POSITION_Y');
    var value = block.getFieldValue('MOTORS_SPEEDS');
    var value = block.getFieldValue('MOUDULE');

    return 'window.AndroidFunction.showToast("fable_set_module_motor_pos_speed");'
};
